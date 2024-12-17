using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aproximari_succesive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[50];
            double eps;
            int n = 0;

            Console.WriteLine("Introduceti x_0");
            x[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti epsilon");
            eps = double.Parse(Console.ReadLine());

            Console.WriteLine($"x[{n}] = {x[n]}");

            do
            {
                n++;
                x[n] = fi(x[n - 1]);
                Console.WriteLine($"x[{n}] = {x[n]}");
            } while (Math.Abs(x[n] - x[n - 1]) >= eps);

            Console.ReadLine();

        }

        public static double fi(double x)
        {
            return Math.Sin(x) + 0.25;
            //return (Math.Pow(x, 5) + 1) / 5;
            //return NthRoot(x + 1, 3);
            //return NthRoot(x + 1, 4);
        }

        public static double NthRoot(double x, double n)
        {
            return Math.Pow(x, 1 / n);
        }
    }
}
