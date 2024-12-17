using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aproximarea_radicalilor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, eps;
            Console.WriteLine("Introduceti c");
            c = double.Parse(Console.ReadLine());


            int k;
            Console.WriteLine("Introduceti k");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti epsilon!");
            eps = double.Parse(Console.ReadLine());

            double[] x = new double[50];
            int n = 0;

            x[0] = Math.Max(1, c);

            Console.WriteLine($"x[{n}] = {x[n]}");

            x[1] = x[0] - (Math.Pow(x[0], k) - c) / (k * Math.Pow(x[0], k - 1));
            n++;
            Console.WriteLine($"x[{n}] = {x[n]}");


            while (Math.Abs(x[n] - x[n - 1]) >= eps)
            {
                x[n+1] = x[n] - (Math.Pow(x[n], k) - c) / (k * Math.Pow(x[n], k - 1));
                n++;
                Console.WriteLine($"x[{n}] = {x[n]}");
            }

            Console.WriteLine("stop");
            Console.ReadLine();
        }
    }
}
