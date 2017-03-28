
using System;

namespace NClose {

    public static class Extensions {

        #region 1 arguments

        public static Func<TResult> Enclose<T1, TResult>(
            this Func<T1, TResult> source, T1 arg1) =>
            () => source(arg1);

        public static Action Enclose<T1>(
            this Action<T1> source, T1 arg1) =>
            () => source(arg1);
		#endregion

#region 2 arguments

        public static Func<T2, TResult> EncloseL1<T1, T2, TResult>(
            this Func<T1, T2, TResult> source, T1 arg1) =>
            (arg2) => source(arg1, arg2);

        public static Func<T1, TResult> EncloseR1<T1, T2, TResult>(
            this Func<T1, T2, TResult> source, T2 arg2) =>
            (arg1) => source(arg1, arg2);

        public static Func<TResult> Enclose<T1, T2, TResult>(
            this Func<T1, T2, TResult> source, T1 arg1, T2 arg2) =>
            () => source(arg1, arg2);

        public static Action<T2> EncloseL1<T1, T2>(
            this Action<T1, T2> source, T1 arg1) =>
            (arg2) => source(arg1, arg2);

        public static Action<T1> EncloseR1<T1, T2>(
            this Action<T1, T2> source, T2 arg2) =>
            (arg1) => source(arg1, arg2);

        public static Action Enclose<T1, T2>(
            this Action<T1, T2> source, T1 arg1, T2 arg2) =>
            () => source(arg1, arg2);
		#endregion

#region 3 arguments

        public static Func<T2, T3, TResult> EncloseL1<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> source, T1 arg1) =>
            (arg2, arg3) => source(arg1, arg2, arg3);

        public static Func<T1, T2, TResult> EncloseR1<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> source, T3 arg3) =>
            (arg1, arg2) => source(arg1, arg2, arg3);

        public static Func<T3, TResult> EncloseL2<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> source, T1 arg1, T2 arg2) =>
            (arg3) => source(arg1, arg2, arg3);

        public static Func<T1, TResult> EncloseR2<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> source, T2 arg2, T3 arg3) =>
            (arg1) => source(arg1, arg2, arg3);

        public static Func<TResult> Enclose<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> source, T1 arg1, T2 arg2, T3 arg3) =>
            () => source(arg1, arg2, arg3);

        public static Action<T2, T3> EncloseL1<T1, T2, T3>(
            this Action<T1, T2, T3> source, T1 arg1) =>
            (arg2, arg3) => source(arg1, arg2, arg3);

        public static Action<T1, T2> EncloseR1<T1, T2, T3>(
            this Action<T1, T2, T3> source, T3 arg3) =>
            (arg1, arg2) => source(arg1, arg2, arg3);

        public static Action<T3> EncloseL2<T1, T2, T3>(
            this Action<T1, T2, T3> source, T1 arg1, T2 arg2) =>
            (arg3) => source(arg1, arg2, arg3);

        public static Action<T1> EncloseR2<T1, T2, T3>(
            this Action<T1, T2, T3> source, T2 arg2, T3 arg3) =>
            (arg1) => source(arg1, arg2, arg3);

        public static Action Enclose<T1, T2, T3>(
            this Action<T1, T2, T3> source, T1 arg1, T2 arg2, T3 arg3) =>
            () => source(arg1, arg2, arg3);
		#endregion

#region 4 arguments

        public static Func<T2, T3, T4, TResult> EncloseL1<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> source, T1 arg1) =>
            (arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4);

        public static Func<T1, T2, T3, TResult> EncloseR1<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> source, T4 arg4) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4);

        public static Func<T3, T4, TResult> EncloseL2<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> source, T1 arg1, T2 arg2) =>
            (arg3, arg4) => source(arg1, arg2, arg3, arg4);

        public static Func<T1, T2, TResult> EncloseR2<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> source, T3 arg3, T4 arg4) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4);

        public static Func<T4, TResult> EncloseL3<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4) => source(arg1, arg2, arg3, arg4);

        public static Func<T1, TResult> EncloseR3<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> source, T2 arg2, T3 arg3, T4 arg4) =>
            (arg1) => source(arg1, arg2, arg3, arg4);

        public static Func<TResult> Enclose<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            () => source(arg1, arg2, arg3, arg4);

        public static Action<T2, T3, T4> EncloseL1<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> source, T1 arg1) =>
            (arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4);

        public static Action<T1, T2, T3> EncloseR1<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> source, T4 arg4) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4);

        public static Action<T3, T4> EncloseL2<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> source, T1 arg1, T2 arg2) =>
            (arg3, arg4) => source(arg1, arg2, arg3, arg4);

        public static Action<T1, T2> EncloseR2<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> source, T3 arg3, T4 arg4) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4);

        public static Action<T4> EncloseL3<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4) => source(arg1, arg2, arg3, arg4);

        public static Action<T1> EncloseR3<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> source, T2 arg2, T3 arg3, T4 arg4) =>
            (arg1) => source(arg1, arg2, arg3, arg4);

        public static Action Enclose<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            () => source(arg1, arg2, arg3, arg4);
		#endregion

#region 5 arguments

        public static Func<T2, T3, T4, T5, TResult> EncloseL1<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<T1, T2, T3, T4, TResult> EncloseR1<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T5 arg5) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<T3, T4, T5, TResult> EncloseL2<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<T1, T2, T3, TResult> EncloseR2<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T4 arg4, T5 arg5) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<T4, T5, TResult> EncloseL3<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<T1, T2, TResult> EncloseR3<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T3 arg3, T4 arg4, T5 arg5) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<T5, TResult> EncloseL4<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<T1, TResult> EncloseR4<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5);

        public static Func<TResult> Enclose<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            () => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T2, T3, T4, T5> EncloseL1<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T1, T2, T3, T4> EncloseR1<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T5 arg5) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T3, T4, T5> EncloseL2<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T1, T2, T3> EncloseR2<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T4 arg4, T5 arg5) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T4, T5> EncloseL3<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T1, T2> EncloseR3<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T3 arg3, T4 arg4, T5 arg5) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T5> EncloseL4<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action<T1> EncloseR4<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5);

        public static Action Enclose<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            () => source(arg1, arg2, arg3, arg4, arg5);
		#endregion

#region 6 arguments

        public static Func<T2, T3, T4, T5, T6, TResult> EncloseL1<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T1, T2, T3, T4, T5, TResult> EncloseR1<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T6 arg6) =>
            (arg1, arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T3, T4, T5, T6, TResult> EncloseL2<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T1, T2, T3, T4, TResult> EncloseR2<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T5 arg5, T6 arg6) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T4, T5, T6, TResult> EncloseL3<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T1, T2, T3, TResult> EncloseR3<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T4 arg4, T5 arg5, T6 arg6) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T5, T6, TResult> EncloseL4<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T1, T2, TResult> EncloseR4<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T6, TResult> EncloseL5<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<T1, TResult> EncloseR5<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Func<TResult> Enclose<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            () => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T2, T3, T4, T5, T6> EncloseL1<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T1, T2, T3, T4, T5> EncloseR1<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T6 arg6) =>
            (arg1, arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T3, T4, T5, T6> EncloseL2<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T1, T2, T3, T4> EncloseR2<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T5 arg5, T6 arg6) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T4, T5, T6> EncloseL3<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T1, T2, T3> EncloseR3<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T4 arg4, T5 arg5, T6 arg6) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T5, T6> EncloseL4<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T1, T2> EncloseR4<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T6> EncloseL5<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action<T1> EncloseR5<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5, arg6);

        public static Action Enclose<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            () => source(arg1, arg2, arg3, arg4, arg5, arg6);
		#endregion

#region 7 arguments

        public static Func<T2, T3, T4, T5, T6, T7, TResult> EncloseL1<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T1, T2, T3, T4, T5, T6, TResult> EncloseR1<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T7 arg7) =>
            (arg1, arg2, arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T3, T4, T5, T6, T7, TResult> EncloseL2<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T1, T2, T3, T4, T5, TResult> EncloseR2<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T6 arg6, T7 arg7) =>
            (arg1, arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T4, T5, T6, T7, TResult> EncloseL3<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T1, T2, T3, T4, TResult> EncloseR3<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T5, T6, T7, TResult> EncloseL4<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T1, T2, T3, TResult> EncloseR4<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T6, T7, TResult> EncloseL5<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T1, T2, TResult> EncloseR5<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T7, TResult> EncloseL6<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<T1, TResult> EncloseR6<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Func<TResult> Enclose<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            () => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T2, T3, T4, T5, T6, T7> EncloseL1<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T1, T2, T3, T4, T5, T6> EncloseR1<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T7 arg7) =>
            (arg1, arg2, arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T3, T4, T5, T6, T7> EncloseL2<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T1, T2, T3, T4, T5> EncloseR2<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T6 arg6, T7 arg7) =>
            (arg1, arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T4, T5, T6, T7> EncloseL3<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T1, T2, T3, T4> EncloseR3<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T5, T6, T7> EncloseL4<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T1, T2, T3> EncloseR4<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T6, T7> EncloseL5<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T1, T2> EncloseR5<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T7> EncloseL6<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action<T1> EncloseR6<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static Action Enclose<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            () => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		#endregion

#region 8 arguments

        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> EncloseL1<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> EncloseR1<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T8 arg8) =>
            (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T3, T4, T5, T6, T7, T8, TResult> EncloseL2<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, T2, T3, T4, T5, T6, TResult> EncloseR2<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T4, T5, T6, T7, T8, TResult> EncloseL3<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, T2, T3, T4, T5, TResult> EncloseR3<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T5, T6, T7, T8, TResult> EncloseL4<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, T2, T3, T4, TResult> EncloseR4<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T6, T7, T8, TResult> EncloseL5<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, T2, T3, TResult> EncloseR5<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T7, T8, TResult> EncloseL6<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, T2, TResult> EncloseR6<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T8, TResult> EncloseL7<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<T1, TResult> EncloseR7<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Func<TResult> Enclose<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            () => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T2, T3, T4, T5, T6, T7, T8> EncloseL1<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1) =>
            (arg2, arg3, arg4, arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T1, T2, T3, T4, T5, T6, T7> EncloseR1<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T8 arg8) =>
            (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T3, T4, T5, T6, T7, T8> EncloseL2<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1, T2 arg2) =>
            (arg3, arg4, arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T1, T2, T3, T4, T5, T6> EncloseR2<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3, arg4, arg5, arg6) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T4, T5, T6, T7, T8> EncloseL3<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1, T2 arg2, T3 arg3) =>
            (arg4, arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T1, T2, T3, T4, T5> EncloseR3<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3, arg4, arg5) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T5, T6, T7, T8> EncloseL4<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            (arg5, arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T1, T2, T3, T4> EncloseR4<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3, arg4) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T6, T7, T8> EncloseL5<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
            (arg6, arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T1, T2, T3> EncloseR5<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2, arg3) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T7, T8> EncloseL6<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
            (arg7, arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T1, T2> EncloseR6<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1, arg2) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T8> EncloseL7<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
            (arg8) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action<T1> EncloseR7<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            (arg1) => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static Action Enclose<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> source, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            () => source(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		#endregion


    }
}