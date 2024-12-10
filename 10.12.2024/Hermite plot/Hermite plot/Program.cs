using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hermite_plot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, fa, fb, dfa, dfb, x;

            a = Math.PI / 6;
            b = Math.PI / 2;
            fa = (double)1 / 2;
            fb = 1;
            dfa = Math.Sqrt(3) / 2;
            dfb = 0;

            double h = (b - a) / 1000;

            for (int i = 0; i <= 1000; i++)
            {
                x = a + i * h;
                //Console.WriteLine(H(a, b, fa, fb, dfa, dfb, x));
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        static double H(double a, double b, double fa, double fb, double dfa, double dfb, double x)
        {
            return ((Math.Pow(b - x, 2) * (x - a)) / Math.Pow(b - a, 2)) * dfa
              - ((Math.Pow(x - a, 2) * (b - x)) / Math.Pow(b - a, 2)) * dfb
              + ((Math.Pow(b - x, 2) * (2 * (x - a) + (b - a))) / Math.Pow(b - a, 3)) * fa
              + ((Math.Pow(x - a, 2) * (2 * (b - x) + (b - a))) / Math.Pow(b - a, 3)) * fb;

        }
    }
}
