### Intriduction :
Most of the application works with the data. Sometimes that data will be hard-coded in your application. Here , we will deals with the literals values that contain diffrent data types.

**what is a Literal value?**
Ans: A literal value is a constant value that never changes. 

**use floating points Literals**
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits

- **Console.WriteLine(0.25F);**
To create a float literal, append the letter F after the number.

- **Console.WriteLine(2.625);**
To create a double literal, just enter a decimal number.

- **Console.WriteLine(12.39816m);**
To create a decimal literal, append the letter m after the number. In this context, the m is called a literal suffix. 


**The main takeaway is that there are many data types, but you'll focus on just a few for now:**

- string for words, phrases, or any alphanumeric data for presentation, not calculation
- char for a single alphanumeric character
- int for a whole number
- decimal for a number with a fractional component
- bool for a true/false value

**Declared Implicitly typed local Variables?**
Ans: An implicitly typed local variable is created by using the var keyword followed by a variable initialization. For example:

C#
**var message = "Hello world!";**
In this example, a string variable was created using the var keyword instead of the string keyword.

The var keyword tells the C# compiler that the data type is implied by the assigned value. After the type is implied, the variable acts the same as if the actual data type had been used to declare it. The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context.

It's important to understand that the var keyword is dependent on the value you use to initialize the variable. If you try to use the var keyword without initializing the variable, you'll receive an error when you attempt to compile your code.

C#
**var message;**
If you attempt to run this code, as it compiles, you'll see the following output:

Output
CS0818: Implicitly-typed variables must be initialized


- When you begin developing code for a task, you may not immediately know what data type to use. Using var can help you develop your solution more dynamically.