using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parabola_de_regresie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            double[] x, y;

            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());

            x = new double[n + 1];
            y = new double[n + 1];

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Introduceti x[{i}]");
                x[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Introduceti y[{i}]");
                y[i] = double.Parse(Console.ReadLine());
            }

            double S1 = 0, S2 = 0, S3 = 0, S4 = 0, T1 = 0, T2 = 0, T3 = 0;

            for (int i = 0; i <= n; i++)
            {
                S1 = S1 + x[i];
                S2 = S2 + x[i] * x[i];
                S3 = S3 + x[i] * x[i] * x[i];
                S4 = S4 + x[i] * x[i] * x[i] * x[i];

                T1 = T1 + y[i];
                T2 = T2 + x[i] * y[i];
                T3 = T3 + x[i] * x[i] * y[i];
            }

            double d, d1, d2, d3;

            d = (n + 1) * S2 * S4 + 2 * S1 * S2 * S3 - S2 * S2 * S2 - S1 * S1 * S4 - (n + 1) * S3 * S3;
            d1 = (n + 1) * S2 * T3 + S1 * S2 * T2 + S1 * S3 * T1 - S2 * S2 * T1 - S1 * S1 * T2 - (n + 1) * S3 * T2;
            d2 = (n + 1) * T2 * S4 + S4 + S2 * S3 * T1 + S1 * S2 * T3 - S2 * S2 * T2 - S1 * S4 * T1 - (n + 1) * S3 * T3;
            d3 = S2 * S4 * T1 + S1 * S3 * T3 + S2 * S3 * T2 - S2 * S2 * T3 - S1 * S4 * T2 - S3 * S3 * T1;

            double a, b, c;

            a = d1 / d;
            b = d2 / d;
            c = d3 / d;

            Console.WriteLine($"{a}, {b}, {c}");

            double start = double.Parse(Console.ReadLine());
            double end = double.Parse(Console.ReadLine());

            double h = (end - start) / 1000;

            for (int i = 0; i < 1000; i++)
            {
                double u = start + i * h;
                double q = a * u * u + b * u + c;

                Console.WriteLine(q);
            }

            Console.ReadLine();

        }
    }
}
