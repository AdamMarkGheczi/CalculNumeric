using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hermite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, fa, fb, dfa, dfb, x;

            Console.WriteLine("Introduceti a");
            //a = double.Parse(Console.ReadLine());

            //a = Math.PI / 6;
            a = Math.PI / 6;


            Console.WriteLine("Introduceti b");
            //b = double.Parse(Console.ReadLine());
            //b = Math.PI / 3;

            b = Math.PI / 3;

            Console.WriteLine("Introduceti fa");
            //fa = double.Parse(Console.ReadLine());
            //fa = (double)1 / 2;

            fa = (double)1 / 2;

            Console.WriteLine("Introduceti fb");
            //fb = double.Parse(Console.ReadLine());
            //fb = Math.Sqrt(3) / 2;

            fb = Math.Sqrt(3) / 2;

            Console.WriteLine("Introduceti dfa");
            //dfa = double.Parse(Console.ReadLine());

            //dfa = Math.Sqrt(3) / 2;
            dfa = Math.Sqrt(3) / 2;

            Console.WriteLine("Introduceti dfb");
            //dfb = double.Parse(Console.ReadLine());

            //dfb = (double)1 / 2;
            dfb = (double)1 / 2;

            Console.WriteLine("Introduceti x");
            //x = double.Parse(Console.ReadLine());

            //x = Math.PI / 5;
            x = Math.PI / 5;

            Console.WriteLine(H(a, b, fa, fb, dfa, dfb, x));

            Console.ReadLine();
        }

        public static double H(double a, double b, double fa, double fb, double dfa, double dfb, double x)
        {
            return ((Math.Pow(b - x, 2) * (x - a)) / Math.Pow(b - a, 2)) * dfa
                - ((Math.Pow(x - a, 2) * (b - x)) / Math.Pow(b - a, 2)) * dfb
                + ((Math.Pow(b - x, 2) * (2 * (x - a) + (b - a))) / Math.Pow(b - a, 3)) * fa
                + ((Math.Pow(x - a, 2) * (2 * (b - x) + (b - a))) / Math.Pow(b - a, 3)) * fb;
        }
    }
}
