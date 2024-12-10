using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Seidel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[50000];
            double[] y = new double[50000];
            double[] z = new double[50000];

            double eps;
            int n = 0;

            Console.WriteLine("Introduceti x_0");
            x[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y_0");
            y[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z_0");
            z[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti epsilon");
            eps = double.Parse(Console.ReadLine());

            Console.WriteLine($"x[{n}] = {x[n]}   y[{n}] = {y[n]}   z[{n}] = {z[n]}");

            x[1] = F1(x[0], y[0], z[0]);
            y[1] = F2(x[0], y[0], z[0]);
            z[1] = F3(x[0], y[0], z[0]);
            
            n++;
            Console.WriteLine($"x[{n}] = {x[n]}   y[{n}] = {y[n]}   z[{n}] = {z[n]}");
            do
            {
                n++;
                x[n] = F1(x[n - 1], y[n - 1], z[n - 1]);
                y[n] = F2(x[n], y[n - 1], z[n - 1]);
                z[n] = F3(x[n], y[n], z[n - 1]);
                Console.WriteLine($"x[{n}] = {x[n]}   y[{n}] = {y[n]}   z[{n}] = {z[n]}");

            } while (Math.Abs(x[n] - x[n - 1]) >= eps || Math.Abs(y[n] - y[n - 1]) >= eps || Math.Abs(z[n] - z[n - 1]) >= eps);

            Console.ReadLine();

        }

        public static double F1(double x, double y, double z)
        {
            return Math.Sqrt(0.5 * (y * z + 5 * x - 1));
        }

        public static double F2(double x, double y, double z)
        {
            return Math.Sqrt(2 * x + Math.Log(z));
        }

        public static double F3(double x, double y, double z)
        {
            return Math.Sqrt(x * y + 2 * z + 8);
        }

    }
}
