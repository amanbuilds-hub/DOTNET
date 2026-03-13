### Character escape sequences
An escape character sequence is an instruction to the runtime to insert a special character that will affect the output of your string. In C#, the escape character sequence begins with a backslash \ followed by the character you're escaping. For example, the \n sequence will add a new line, and a \t sequence will add a tab.

The following code uses escape character sequences to add newlines and tabs:

C#

**Console.WriteLine("Hello\nWorld!");**
**Console.WriteLine("Hello\tWorld!");**

If you run the code, you'll see the following output:

Output:

**Hello**
**World!**
**Hello   World!**

What if you need to insert a double-quotation mark in a literal string? If you don't use the character escape sequence, you'll confuse the compiler because it will think you want to terminate the string prematurely. The compiler won't understand the purpose of the characters after the second double-quotation mark.

C#
**Console.WriteLine("Hello "World"!");**
The C# Code Editor will put a red squiggly line under World. But if you attempt to run the code anyway, you would see the following output:

Error summary:
  CS1003: Syntax error, ',' expected
  CS0103: The name 'World' does not exist in the current context
  CS1003: Syntax error, ',' expected
To handle that situation, use the \" escape sequence:

C#
**Console.WriteLine("Hello \"World\"!");**
If you run the code above, you would see the following output:

Output
Hello "World"!

*In case of Showing the file path*
Need to insert '\\' instead of '\'.

**Console.WriteLine("c:\\source\\repos");**
Output:
c:\source\repos


### Verbatim string literal
A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.

**Console.WriteLine(@"    c:\source\repos    (this is where your code goes)");**

Output:
**c:\source\repos    (this is where your code goes)**


### String Interpolation
String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions. An interpolation expression is indicated by an opening and closing curly brace symbol { }.

Instead of writing the following line of code:

**string message = greeting + " " + firstName + "!";**

You can write this more concise line of code instead:

**string message = $"{greeting} {firstName}!";**


## Combine verbatim literals and string interpolation
Suppose you need to use a verbatim literal in your template. You can use both the verbatim literal prefix symbol @ and the string interpolation $ symbol together.

**string projectName = "First-Project";**
**Console.WriteLine($@"C:\Output\{projectName}\Data");**

Output:
**C:\Output\First-Project\Data**