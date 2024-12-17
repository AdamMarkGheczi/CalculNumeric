using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_modificata_a_tangentei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, eps, dda, d0;
            Console.WriteLine("Introduceti capetele intervalului!");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti dda!");
            dda = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti d0!");
            d0 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti epsilon!");
            eps = double.Parse(Console.ReadLine());

            double[] x = new double[50];
            int n = 0;

            if (f(a) * dda > 0) x[0] = a;
            else x[0] = b;

            Console.WriteLine($"x[{n}] = {x[n]}");

            x[1] = x[0] - f(x[0]) / d0;
            n++;
            Console.WriteLine($"x[{n}] = {x[n]}");


            while (Math.Abs(x[n] - x[n - 1]) >= eps)
            {
                x[n + 1] = x[n] - f(x[n]) / d0;
                n++;
                Console.WriteLine($"x[{n}] = {x[n]}");
            }

            Console.WriteLine("stop");
            Console.ReadLine();
        }

        static double f(double x)
        {
            return x * x * x  - x - 1;
        }

    }
}
