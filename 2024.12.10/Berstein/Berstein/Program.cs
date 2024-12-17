using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berstein
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            a = 0;
            b = 1;

            double h = (b - a) / 1000;

            for (int i = 0; i <= 1000; i++)
            {
                double x = a + i * h;
                Console.WriteLine(B2(x));
                //Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        static double B1(double x)
        {
            return 1 - x + x * Math.E;
        }

        static double B2(double x)
        {
            return Math.Pow(1 - x, 2) + 2 * x * (1 - x) * Math.Sqrt(Math.E) + Math.Pow(x, 2) * Math.E;
        }

        static double B3(double x)
        {
            return Math.Pow(1 - x, 3) + 3 * Math.Pow(1 - x, 2) * x * Math.Pow(Math.E, (double)1/3) + 3 * Math.Pow(x, 2) * (1 - x) * Math.Pow(Math.E, (double)2 / 3) + Math.Pow(x, 3) * Math.E;
        }
    }
}
