// See https://aka.ms/new-console-template for more information
string message = "Hello World";
Console.WriteLine(message);

string emptyMessage = string.Empty;

string stringWithDoubleQuote = "This is a string with a double quote: \"bookkkk\" ";
Console.WriteLine(stringWithDoubleQuote);

string filePath = "C:\\temp";
Console.WriteLine(filePath);
string filePath2 = @"C:\temp";
Console.WriteLine(filePath2);

// string length
Console.WriteLine(filePath.Length);

// string concatenation
string firstName = "James";
string lastName = "olanipekun";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

// string interpolation
Console.WriteLine($"{firstName} {lastName} {12 * 12}");

// string Substrings
string first5Characters = fullName.Substring(10);
Console.WriteLine(first5Characters);