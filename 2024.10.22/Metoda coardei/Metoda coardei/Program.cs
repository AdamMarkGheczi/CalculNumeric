using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_coardei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, eps;
            double[] x = new double[100];
            Console.WriteLine("Introduceti a si b");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti epsilon");
            eps = double.Parse(Console.ReadLine());

            int n = 0;


            if (f(a) * fdd(a) < 0)
            {
                x[0] = a;

                do
                {
                    x[n + 1] = x[n] - f(x[n]) / (f(b) - f(x[n])) * (b - x[n]);
                    n++;
                    Console.WriteLine($"x[{n}] = {x[n]}, Diferenta: {Math.Abs(x[n] - x[n - 1])}");
                } while (Math.Abs(x[n] - x[n - 1]) >= eps);
            }

            if(f(b) * fdd(b) < 0)
            {
                x[0] = b;
                Console.WriteLine($"x[0] = {b}");
                do
                {
                    x[n + 1] = x[n] - f(x[n]) / (f(a) - f(x[n])) * (a - x[n]);
                    n++;
                    Console.WriteLine($"x[{n}] = {x[n]}, Diferenta: {Math.Abs(x[n] - x[n - 1])}");

                } while (Math.Abs(x[n] - x[n - 1]) >= eps);
            }

            Console.WriteLine($"Solutia: {x[n]}, la iteratia {n}");
            Console.ReadLine();
        }

        public static double f(double x)
        {
            return x * x - 2;
        }

        public static double fdd(double x)
        {
            return 2;
        }
    }
}
