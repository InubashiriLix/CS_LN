using System;

Console.WriteLine("Hello, World!");

int num = 42;
double adding = 1.1;
string msg = "I wanna killl you all!";

double Add(int a, double b) => a + b;
Console.WriteLine(msg);
Console.WriteLine($"Sum of 1 and 2 is {Add(num, adding)}.");

// using linq
var numbers = new[] { 1, 2, 3, 4, 5 };
var evens = numbers.Where(n => n % 2 == 0).ToArray();
Console.WriteLine("Even numbers: " + string.Join(", ", evens));

// error handling
try
{
    int zero = 0;
    int result = num / zero;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Zero can not be devided");
    Console.WriteLine(ex.Message);
    throw;
}
