using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharp6FeaturesExample
{
    class DictionaryInitializer
    {
        static void Main(string[] args)
        {
            // Before C# 6.0
            Dictionary<string, Uri> urls = new Dictionary<string, Uri>
            {
                {"Google", new Uri("http://google.com") },
                {"Microsoft"   , new Uri("http://microsoft.com") },
                {"jQuer2DotNet", new Uri("http://jquer2dotnet.com") }
            };

            // In C# 6.0
            Dictionary<string, Uri> urls2 = new Dictionary<string, Uri>
            {
                ["Google"] = new Uri("http://google.com"),
                ["Microsoft"] = new Uri("http://microsoft.com"),
                ["jQuer2DotNet"] = new Uri("http://jquer2dotnet.com")
            };

            ReadLine();
        }

    }
}
