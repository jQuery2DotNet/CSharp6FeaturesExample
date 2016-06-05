using System;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp6FeaturesExample
{
    class AwaitInCatchAndFinallyBlock
    {
        static void Main(string[] args)
        {
            MyMath obj = new MyMath();
            obj.Div(12, 0);

            ReadLine();
        }

        public class MyMath
        {
            public async void Div(int value1, int value2)
            {
                try
                {
                    int res = value1 / value2;
                    WriteLine("Div : {0}", res);
                }
                catch (Exception ex)
                {
                    // Error: Attempted to divide by zero.
                    await asyncMethodForCatch(ex.Message);
                }
                finally
                {
                    await asyncMethodForFinally();
                }
            }
            private async Task asyncMethodForFinally()
            {
                WriteLine("Method from async finally Method !!");
            }

            private async Task asyncMethodForCatch(string message)
            {
                WriteLine($"Method from async Catch Method !! {message}");
            }
        }
    }
}
