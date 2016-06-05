using System;
using static System.Console;
using static System.Math;
using static System.DayOfWeek;

namespace CSharp6FeaturesExample
{
    class UsingStaticQualifier
    {
        static void Main(string[] args)
        {
            // Before C# 6.0
            Console.WriteLine("Welcome to C# feature demo - jQuery2DotNet");
            Console.WriteLine(Sqrt(3 * 3 + 4 * 4));
            Console.WriteLine(Friday - Monday);

            // In C# 6.0
            // The 'using static' Directive
            WriteLine("Welcome to C# feature demo - jQuery2DotNet");
            WriteLine(Sqrt(3 * 3 + 4 * 4));
            WriteLine(Friday - Monday);

            ReadLine();
        }
    }
}
