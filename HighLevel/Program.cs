using System;

namespace HighLevel
{
    public class Program
    {
        static void Main()
        {
            double firstResult;
            double firstArg = 1;
            string readArg = "";

            readArg = Console.ReadLine();
            firstArg = Convert.ToDouble(readArg);
            firstResult = GetFirstFunction(firstArg);

            Console.WriteLine("FirstResult = " + firstResult);
            Console.ReadKey();
        }

        public static double GetFirstFunction(double arg)
        {
            double result = Math.Cos(arg) + Math.Sin(arg) + Math.Cos(3 * arg) + Math.Sin(3 * arg);

            return result;
        }
    }
}
