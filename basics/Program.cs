// See https://aka.ms/new-console-template for more information
using basics;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
int prcentage = -10;

// instance methodes
if (NumberExtensions.IsBetween(prcentage, 0, 100))

    Console.WriteLine("valid");
else
    Console.WriteLine("invalid");

// Extensions methodes
if (prcentage.IsBetween(0, 100))
        Console.WriteLine("valid");
    else
        Console.WriteLine("invalid");


Console.Write("Enter: ");
var input = Console.ReadLine();
Console.WriteLine(input.RemoveWhiteSpaces().Reverse());
 