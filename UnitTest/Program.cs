// See https://aka.ms/new-console-template for more information
using Calculations;

Console.WriteLine("Hello, World!");

Calculator calc = new Calculator();
Console.WriteLine("23 + 45 = " + calc.Add(23, 45));
Console.WriteLine();

Names names = new Names();

Console.WriteLine("My Full Name - " + names.MakeFullNames("Sam", "Pant"));
Console.WriteLine();
Console.ReadLine();
