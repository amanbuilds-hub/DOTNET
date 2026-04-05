// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
// <span> : called mapgic string, because it is a string that we know will be in the message, and we can use it to find the position of the opening tag.

int closingPosition = message.IndexOf("</span>");
Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);
openingPosition += 6;// this is called the magic numbers, because it is the number of characters in the opening tag, and we need to add it to the opening position to get the position of the first character of the value between the tags.
Console.WriteLine(openingPosition);
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

string message1 = "hello there!";

int first_h = message1.IndexOf('h');
int last_h = message1.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


string message2 = "Hello, world!";
char[] charsToFind = ['a', 'e', 'i'];

int index = message2.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message2[index]}' in '{message2}' at index: {index}.");


string message3 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message3}");
char[] openSymbols = [ '[', '{', '(' ];
int startPosition = 5;
int openingPosition1 = message3.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message3[openingPosition1..]}");

int openingPosition2 = message3.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message3[openingPosition2..]}");