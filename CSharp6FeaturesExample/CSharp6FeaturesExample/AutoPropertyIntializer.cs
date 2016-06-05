using static System.Console;

namespace CSharp6FeaturesExample
{
    class AutoPropertyIntializer
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            // Print data
            WriteLine($"Home Address: {address?.HomeAddress ?? "Home address not avilable"}");
            WriteLine($"Office Address: {address?.OfficeAddress ?? "Office address not avilable"}");

            ReadLine();
        }

        // In C# 6.0
        class Address
        {
            public string HomeAddress { get; set; } = "Delhi";
            public string OfficeAddress { get; } = "New Delhi";
        }

        // Before C# 6.0
        //class Address
        //{
        //    public string HomeAddress { get; set; }
        //    public string OfficeAddress { get { return "New Delhi"; } }
        //    public Address()
        //    {
        //        HomeAddress = "Delhi";
        //    }
        //}
    }
}
