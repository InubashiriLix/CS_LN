using System;
using CustomizeConvertor;
using TypeConversionApplication;

// the little type can be converted into the big type
byte a = 10;
int b = a;

// while converted the long type to the little  type can result in data lose
int intValue = 42;
long longValue = intValue;

// explicit convertion
int i = 10;
byte c = (byte)i;

double doubleValue = 3.14;
int d = (int)doubleValue;
Console.WriteLine($"(int)(3.14) -> 3 => {d}");

double oneThirdDouble = 1.0 / 3;
float oneThirdFloat = (float)oneThirdDouble;
Console.WriteLine($"{oneThirdDouble} -> float -> {oneThirdFloat}");

int intTostring = 1;
Console.WriteLine($"1 to stirng: {intTostring.ToString()}");

ExplicitConversion.Converting();
ExplicitConversion.tryParseTest();
ExplicitConversion.ParseTest();

Fahreheit f = new Fahreheit(123.123);

// implicit convert the Fahreheit into the double
double temp = f;
Console.WriteLine($"implicit convert double {temp}");

// explicit convert the double into the Fahreheit
double test2 = 192.168;
Console.WriteLine($"explicit converting double {((Fahreheit)test2).Degrees}");
