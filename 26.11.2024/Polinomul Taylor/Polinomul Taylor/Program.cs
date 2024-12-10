using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Polinomul_Taylor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a, u;
            double[] f = {0, 1, 0, -1, 0, 1, 0, -1};
            double[] Tf = new double[50];

            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("u = Pi/4");
            //u = double.Parse(Console.ReadLine());
            u = Math.PI / 4;

            Tf[0] = f[0];
            Console.WriteLine($"Tnf(u) = {Tf[0]}");
            for (int i = 1; i <= n; i++)
            {
                Tf[i] = Tf[i - 1] + (1 / Factorial(i)) * Math.Pow(u - a, i) * f[i];
                Console.WriteLine($"Tnf(u) = {Tf[i]}");
            }

            Console.WriteLine($"Tnf(u) = {Tf[n]}, sin(Pi/4) = {Math.Sin(Math.PI/4)}");
            Console.WriteLine($"Tnf(u) * 2 = {Tf[n] * 2}, Sqrt(2) = {Math.Sqrt(2)}");

            Console.ReadLine();
        }

        public static double Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return (double)result;
        }
    }
}
