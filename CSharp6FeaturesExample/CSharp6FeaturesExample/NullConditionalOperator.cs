using System;
using static System.Console;

namespace CSharp6FeaturesExample
{
    class NullConditionalOperator
    {
        static void Main(string[] args)
        {
            Address address = null;
            // Check with data
            //Address address = new Address() { HomeAddress = "Delhi" };

            // Before C# 6.0
            Console.WriteLine(String.Format("Home Address: {0}",
                address == null ? "Home address not avilable" : address.HomeAddress));

            // In C# 6.0
            // define multiple string values by “\{ variable }”
            WriteLine($"Home Address: {address?.HomeAddress ?? "Home address not avilable"}");

            ReadLine();
        }

        class Address
        {
            public string HomeAddress { get; set; }
        }
    }
}
