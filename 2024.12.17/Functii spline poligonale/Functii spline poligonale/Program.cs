using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functii_spline_poligonale
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            for (int i = 0; i < 1000; i++)
            {
                double u = a * i * step;

                for (int j = 1; j <= n; j++)
                {
                    if (x[j - 1] <= u && u <= x[j])
                    {
                        double s = y[j - 1] + ((y[j] - y[j - 1]) / h[j]) * (u - x[j - 1]);

                        //Console.WriteLine(u);
                        Console.WriteLine(s);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}