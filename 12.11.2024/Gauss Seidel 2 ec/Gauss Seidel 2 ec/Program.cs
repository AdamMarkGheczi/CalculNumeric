using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Seidel_2_ec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[50000];
            double[] y = new double[50000];

            double eps;
            int n = 0;

            Console.WriteLine("Introduceti x_0");
            x[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y_0");
            y[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti epsilon");
            eps = double.Parse(Console.ReadLine());

            Console.WriteLine($"x[{n}] = {x[n]}   y[{n}] = {y[n]}");

            x[1] = F(x[0], y[0]);
            y[1] = G(x[0], y[0]);

            n++;
            Console.WriteLine($"x[{n}] = {x[n]}   y[{n}] = {y[n]}");
            do
            {
                n++;
                x[n] = F(x[n - 1], y[n - 1]);
                y[n] = G(x[n], y[n - 1]);
                Console.WriteLine($"x[{n}] = {x[n]}   y[{n}] = {y[n]}");

            } while (Math.Abs(x[n] - x[n - 1]) >= eps || Math.Abs(y[n] - y[n - 1]) >= eps);

            Console.ReadLine();

        }

        public static double F(double x, double y)
        {
            return Math.Sqrt((x * (y + 5) - 1) / 2);
        }

        public static double G(double x, double y)
        {
            return Math.Sqrt(x + 3 * Math.Log10(x));
        }
    }
}
