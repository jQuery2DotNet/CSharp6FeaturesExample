using static System.Console;

namespace CSharp6FeaturesExample
{
    class ExpressionBodiesFunctions
    {
        static void Main(string[] args)
        {
            CalCulator calCulator = new CalCulator();
            // Print data
            WriteLine($"Add 1 + 4 = {calCulator.Add(1, 4)}");
            WriteLine($"Multiply 2 * 2 = {calCulator.Multiply(2, 2)}");

            ReadLine();
        }

        // In C# 6.0
        public class CalCulator
        {
            public int Add(int num1, int num2) => num1 + num2;
            public int Multiply(int num1, int num2) => num1 * num2;
        }

        // Before C# 6.0
        //public class CalCulator
        //{
        //    public int Add(int num1, int num2)
        //    {
        //        return num1 + num2;
        //    }
        //    public int Multiply(int num1, int num2)
        //    {
        //        return num1 * num2;
        //    }
        //}
    }
}
