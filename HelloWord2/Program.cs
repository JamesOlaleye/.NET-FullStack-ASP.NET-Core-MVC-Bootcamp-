/*
Console.WriteLine("Enter your name: ");

string? name = Console.ReadLine();

Console.WriteLine($"Hello, {name}!");
*/

// bool - boolean
bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

// char : don't use double quotes -single string only
char c1 = 'a';
Console.WriteLine($"char: {c1}");

// int : store values btw -2billion to +2billion
int a = 0;
int b = 5;
int c = -7;

Console.WriteLine($"a: {a}, b: {b}, c: {c}");

// arithmetic operations: int allows us to do arithmetic operations
int multiply = b * c;
int divide = c / b;
int add = a + b;
int subtract = a - b;

Console.WriteLine($"multiply: {multiply}, divide: {divide}, add: {add}, subtract: {subtract}");

// long 
long i = 99;
Console.WriteLine($"long: {i}");

// floating point number types
float f = 3.5f; // single - single precision
double g = 7.8d; // double - double precision
decimal dec = 7.15m; //decimal - high precision

Console.WriteLine($"f: {f}, g: {g}, dec: {dec}");

Console.WriteLine($"float calculation: {1.1111111f / 0.8324234f}");
Console.WriteLine($"double calculation: {1.1111111d / 0.8324234d}");
Console.WriteLine($"decimal calculation: {1.1111111m / 0.8324234m}");

int a1 = 7;
int a2 = a1;
a1 = 5;
Console.WriteLine($"a1: {a1}, a2: {a2}");

// Nullable value Types
int? i1 = null;
bool? b1 = null;
Console.WriteLine($"int: {i1}, bool: {b1}");

// TYPE CONVERSION
int age = 30;
float weight = 75.8f;
Console.WriteLine($"age: {age}, weight: {weight}");
//implicit type conversion
long myAge = age;
//explicit type conversion
int lessWeight = (int)weight; // precission loss
int notMyAge = (int)myAge; // no precission loss


long bigNumber = 1111111111111111111;
int smallerType = (int)bigNumber;
Console.WriteLine($"smallerType: {smallerType}");

