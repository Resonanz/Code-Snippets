# Exception handling

## Book: Interactive C#

* In general, when we write code for an application, we
have the expectation that it will always execute without any problem. But sometimes, we encounter sudden surprises when we execute those programs. These surprises may occur in various ways and through some careless mistakes (e.g., trying to implement the wrong logic, or ignoring some loopholes in the code paths of the program, etc.) However, it is also true that many of the failures are beyond the control of a programmer. We often call these unwanted situations exceptions.

* We can define an exception as an event, which breaks the normal execution/instruction flow.

* When exceptional situations arise, an exception object is created and thrown into the method that created the exception. That method may or may not handle the exception. If it cannot handle the exception, it will pass the responsibility to another method. (Similar to our daily life, when a situation goes beyond our control, we seek advice from others).

* If there is no method to take the responsibility of handling a particular exception, an error dialog box appears (indicating an unhandled exception) and the execution of the program stops.

### Some key points about the exception handling mechanism.

* All exceptions in .NET are objects.

* System.Exception is the base class for the exceptions.

* Any method in an application can raise surprises during the
application’s runtime. If such a situation occurs, in programming
terminology, we say that the method has thrown an exception.

* We use the following keywords to deal with C# exceptions: try, catch,
throw, finally

* **We try to guard an exception with try/catch block. The code that may
throw an exception is placed inside a try block and this exceptional
situation is handled inside a catch block.**

* We can associate multiple catch blocks with a try block. When a
particular catch block handles the sudden surprises, we say that the
catch block has caught the exception.

* **The code in the finally block must execute.** A finally block is generally
placed after a try block or a try/catch block.

* When an exception is raised inside a try block, the control jumps to
the respective catch or finally block. The remaining part of the try
block will not be executed.

* Exceptions follow the inheritance hierarchy. Sometimes we may
encounter compile-time errors if we place a catch block (e.g., catch
block1) that can handle a parent class exception before a catch block
(e.g., catch block2) that can handle only the derive class exception.
From the compiler’s point of view, it is an example of unreachable
code, because in this case, catch block1 is already able to handle the
exceptions that catch block2 can handle. Therefore, control does
not need to reach catch block2 at all. We will examine this case in an
example.

* We can use any combination: try/catch, try/catch/finally, or try/
finally.

* The code in finally block must execute.

* If we do not handle exceptions, the CLR will catch it on our behalf
and our program may die prematurely.

There is a key difference with Java: here all exceptions are
implicitly unchecked. Therefore, there is no concept of the throws
keyword in C#. This is a hot topic of debate.