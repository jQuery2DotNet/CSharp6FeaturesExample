using System;
using static System.Console;

namespace CSharp6FeaturesExample
{
    class StringInterpolation
    {
        static void Main(string[] args)
        {
            string firstName = "Raj", lastName = "Patel";

            // Before C# 6.0
            Console.WriteLine(String.Format("My name is {0} {1}", firstName, lastName));

            // In C# 6.0
            // define multiple string values by “\{ variable }”
            // Just make sure you use the $ before the start of the string.
            WriteLine($"My name is {firstName} {lastName}");
            WriteLine($"Current datetime : {DateTime.Now}");

            ReadLine();
        }
    }
}
