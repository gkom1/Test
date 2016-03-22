using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public static double GetArea(double a, double b, double c, out string toLog)
        {
            double[] sides = new[] { a, b, c };
            Array.Sort(sides);
            if (sides[2] * sides[2] != sides[0] * sides[0] + sides[1] * sides[1])
            {
                toLog = "ERROR: given triangle is not rightangled";
                return -1.0;
            }
            else
            {
                toLog = "";
                return sides[1] * sides[2];
            }
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string toLog = "";
            double x = GetArea(a, b, c, out toLog);
            if (x > 0)
                Console.WriteLine(x);
            else
                Console.WriteLine(toLog);
            Console.ReadLine();
        }
    }
}
