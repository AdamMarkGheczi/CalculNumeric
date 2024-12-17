using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, eps;
            int n = 0;

            double[] x = new double[50];

            Console.WriteLine("Introduceti a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti x[0]: ");
            x[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti epsilon: ");
            eps = double.Parse(Console.ReadLine());

            Console.WriteLine($"x[{n}] = {x[n]}");
            do
            {
                n++;
                x[n] = (x[n - 1] + a / x[n - 1]) / 2;
                Console.WriteLine($"x[{n}] = {x[n]}");

            } while (Math.Abs(x[n] - x[n - 1]) >= eps);

            Console.ReadLine();
        }
    }
}
