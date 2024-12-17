using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functii_spline_patratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // gresit
            int n;

            Console.WriteLine("Introduceti capetele intrevalului");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

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


            double step = (b - a) / 1000;
            double[] h = new double[n + 1];

            for (int i = 1; i <= n; i++) h[i] = x[i] - x[i - 1];

            double[] m = new double[n + 1];

            m[0] = ((2 * h[1] + h[2]) / (h[1] * (h[1] + h[2]))) * (y[1] - y[0]) - (h[1] / (h[1] * (h[1] + h[2]))) * (y[2] - y[1]);

            for (int i = 1; i <= n; i++)
                m[i] = (2 / h[i]) * (y[i] - y[i - 1]) - m[i - 1];


            double[] s = new double[1001];
            double[] u = new double[1001];

            for (int k = 0; k <= 1000; k++)
            {
                u[k] = a + k * step;

                for (int j = 1; j <= n; j++)
                {
                    if (x[j - 1] <= u[k] && u[k] <= x[j])
                    {
                        s[k] = ((m[j] - m[j-1]) / 2 * h[j]) * Math.Pow((u[k] - x[j-1]), 2) + m[j-1] * (u[k] - x[j-1]) + y[j-1];
                    }
                }
            }

            Console.WriteLine("U");
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(u[i]);
            }

            Console.WriteLine("S");

            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.ReadLine();
        }
    }
}
