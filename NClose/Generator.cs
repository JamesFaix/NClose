using System.Collections.Generic;
using System.Text;

namespace NClose {

    public static class Generator {

        public static string GetEncloseFrom1ToNArgs(int maxArgs) {
            var sb = new StringBuilder();
            for (var i = 1; i <= maxArgs; i++) {
                sb.Append(GetMethodsForArgCount(i));
            }
            return sb.ToString();
        }

        static string GetMethodsForArgCount(int argCount) {
            var sb = new StringBuilder();
            sb.AppendLine($"#region {argCount} arguments");

            foreach (var hasResult in new[] { true, false }) {
                for (var i = 1; i <= argCount - 1; i++) {
                    sb.Append(GetLeftEnclose(argCount, hasResult, i));
                    sb.Append(GetRightEnclose(argCount, hasResult, i));
                }
                sb.Append(GetFullEnclose(argCount, hasResult));
            }

            sb.AppendLine($"\t\t#endregion");
            sb.AppendLine();
            return sb.ToString();
        }

        static string GetFullEnclose(int paramCount, bool hasResult) =>
            GetEnclose(paramCount, hasResult, 1, paramCount, 0, 0, "");

        static string GetLeftEnclose(int paramCount, bool hasResult, int enclosedParams) =>
            GetEnclose(paramCount, hasResult, 1, enclosedParams, enclosedParams + 1, paramCount, "L");

        static string GetRightEnclose(int paramCount, bool hasResult, int enclosedParams) =>
            GetEnclose(paramCount, hasResult, paramCount - enclosedParams + 1, paramCount, 1, paramCount - enclosedParams, "R");

        static string GetEnclose(int paramCount, bool hasResult,
            int firstClosedParam, int lastClosedParam, int firstOpenParam, int lastOpenParam,
            string methodNameSuffix) {

            var returnType = GetReturnType(firstOpenParam, lastOpenParam, hasResult);
            var methodTypeParams = GetMethodTypeArguments(paramCount, hasResult);
            var argumentList = GetArgumentList(paramCount, hasResult, firstClosedParam, lastClosedParam);
            var resultParams = GetResultParamList(firstOpenParam, lastOpenParam);
            var resultBody = GetResultBody(paramCount);

            return $@"
        public static {returnType} Enclose{methodNameSuffix}{methodTypeParams}(
            {argumentList}) =>
            {resultParams} => {resultBody};
";
        }

        static string GetReturnType(int firstParam, int lastParam, bool hasResult) =>
            GetDelegateTypeName(hasResult) +
            GetTypeArguments(firstParam, lastParam, hasResult);

        static string GetMethodTypeArguments(int paramCount, bool hasResult) =>
            GetTypeArguments(1, paramCount, hasResult);

        static string GetArgumentList(int delegateParamCount, bool hasResult, int firstParam, int lastParam) {
            var delegateArg = $"this {GetDelegateArgumentType(delegateParamCount, hasResult)} source";
            var enclosedArgs = GetEnclosedArguments(firstParam, lastParam);
            return enclosedArgs.Length > 0
                ? $"{delegateArg}, {enclosedArgs}"
                : delegateArg;
        }

        static string GetResultParamList(int firstParam, int lastParam) {
            var list = IsRangeEmpty(firstParam, lastParam)
                ? ""
                : FromTo(firstParam, lastParam)
                    .ToDelimitedString(", ", "arg{0}");
            return $"({list})";
        }

        static string GetResultBody(int paramCount) {
            var paramList = FromTo(1, paramCount)
                .ToDelimitedString(", ", "arg{0}");
            return $"source({paramList})";
        }

        static string GetDelegateTypeName(bool hasResult) =>
            hasResult ? "Func" : "Action";

        static string GetTypeArguments(int first, int last, bool hasResult) {
            if (IsRangeEmpty(first, last)) {
                return hasResult ? "<TResult>" : "";
            }

            var paramList = FromTo(first, last)
                .ToDelimitedString(", ", "T{0}");

            return hasResult
                ? $"<{paramList}, TResult>"
                : $"<{paramList}>";
        }

        static string GetDelegateArgumentType(int paramCount, bool hasResult) =>
            GetDelegateTypeName(hasResult) +
            GetMethodTypeArguments(paramCount, hasResult);

        static string GetEnclosedArguments(int firstParam, int lastParam) =>
            FromTo(firstParam, lastParam)
                .ToDelimitedString(", ", "T{0} arg{0}");

        static string ToDelimitedString<T>(this IEnumerable<T> seq, string delimiter, string format = "{0}") {
            var sb = new StringBuilder();

            using (var e = seq.GetEnumerator()) {
                if (e.MoveNext()) {
                    sb.AppendFormat(format, e.Current);
                }
                while (e.MoveNext()) {
                    sb.AppendFormat(delimiter + format, e.Current.ToString());
                }
            }

            return sb.ToString();
        }

        static IEnumerable<int> FromTo(int from, int to) {
            for (var i = from; i <= to; i++)
                yield return i;
        }

        static bool IsRangeEmpty(int first, int last) => first < 1 || last < 1;
    }
}
