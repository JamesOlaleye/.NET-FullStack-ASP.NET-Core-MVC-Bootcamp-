/*
String content = "";

try
{
    content = File.ReadAllText("doc.txt");
    Console.WriteLine("The file has been read");
}
catch (FileNotFoundException exception)
{
    Console.WriteLine($"ERROR: The file {exception.FileName} could not be found.");
}
finally
{
    Console.WriteLine($"The content length is: {content.Length}");
}
*/


// REFACTOR TO BELOW
var fileName = "doc.txt";

if(File.Exists(fileName))
{
    var content = File.ReadAllText(fileName);
    Console.WriteLine(content);
}
else
{
    Console.WriteLine("The file does not exist. Do you want to create it?");
}

