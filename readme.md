NClose
--------
NClose is a library for creating closures and performing partial function application in C#.  It provides extension methods for the `Func` and `Action` family of delegates to which take some (or all) of the parameters for the delegate and return a delegate that takes less (or zero) parameters.  

Everything NClose does can also be done with lambda expressions in C#.  These extensions merely give this kind of function composition a more fluent syntax, similar to F#.

