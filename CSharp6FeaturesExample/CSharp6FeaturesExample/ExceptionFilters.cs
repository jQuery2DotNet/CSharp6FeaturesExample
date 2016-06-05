using System;
using static System.Console;

namespace CSharp6FeaturesExample
{
    class ExceptionFilters
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomExceptions = random.Next(400, 405);
            WriteLine("Generated exception: " + randomExceptions);
            Write("Exception type: ");

            try
            {
                throw new Exception(randomExceptions.ToString());
            }
            // In C# 6.0
            catch (Exception ex) when (ex.Message.Equals("400"))
            {
                Write("Bad Request");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                Write("Unauthorized");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                Write("Payment Required");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("403"))
            {
                Write("Forbidden");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("404"))
            {
                Write("Not Found");
                ReadLine();
            }

            ReadLine();
        }
    }
}
