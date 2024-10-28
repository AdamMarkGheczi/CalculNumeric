using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_Injumatatirii_Intervalului
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, eps, SOL;
            Console.WriteLine("Introduceti capetele intervalului:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti toleranta epsilon:");
            eps = double.Parse(Console.ReadLine());


            while (true) {
                c = (a + b) / 2;
                if (Math.Abs(b - c) <= eps)
                {
                    SOL = c;
                    break;
                }

                if (f(b) * f(c) < 0) a = c;
                else b = c;
            }



            Console.WriteLine($"Solutia este: {SOL}");
            Console.ReadLine();
        }

        public static double f(double x)
        {
            return x * x * x - x - 1;
        }
    }
}
