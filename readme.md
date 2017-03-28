NClose
--------
NClose is a library for creating closures and performing partial function application in C#.  It provides extension methods for the `Func` and `Action` family of delegates to which take some (or all) of the parameters for the delegate and return a delegate that takes less (or zero) parameters.  

Everything NClose does can also be done with lambda expressions in C#.  These extensions merely give this kind of function composition a more fluent syntax, similar to F#.

------

The project uses T4 to generate extensions for 1 to N parameters.  The current build goes up to 8, but the template will allow for adding more parameters easily.

The current build targets .NET 4, mainly because that's when `Func` delegates with more than 4 parameters were added.  The number can be lowered to make the library compatible with .NET 3.
