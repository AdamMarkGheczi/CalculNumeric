using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_s_nel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eps;
            double[] x = new double[50], y = new double[50];
            int n = 0;
            Console.WriteLine("Introduceti x0");
            x[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti y0");
            y[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti epsilon");
            eps = double.Parse(Console.ReadLine());

            double J = Fdx(x[0], y[0]) * Gdy(x[0], y[0]) - Fdy(x[0], y[0]) * Gdx(x[0], y[0]);

            Console.WriteLine($"x[{n}] = {x[n]} y[{n}] = {y[n]}");

            do {
                x[n + 1] = x[n] - (1 / J) * (F(x[n], y[n]) * Gdy(x[n], y[n]) - G(x[n], y[n]) * Fdy(x[n], y[n]));
                y[n + 1] = y[n] - (1 / J) * (Fdx(x[n], y[n]) * G(x[n], y[n]) - Gdx(x[n], y[n]) * F(x[n], y[n]));


                n++;
                J = Fdx(x[n], y[n]) * Gdy(x[n], y[n]) - Fdy(x[n], y[n]) * Gdx(x[n], y[n]);
                Console.WriteLine($"x[{n}] = {x[n]} y[{n}] = {y[n]}");

            } while (Math.Abs(x[n] - x[n-1]) >= eps || Math.Abs(y[n] - y[n - 1]) >= eps);

            Console.ReadLine();
        }

        //static double F(double x, double y)
        //{
        //    return 2 * x * x * x - y * y - 1;
        //}
        //static double G(double x, double y)
        //{
        //    return x * y * y * y - y - 4;
        //}
        //static double Fdx(double x, double y)
        //{
        //    return 6 * x * x;
        //}

        //static double Fdy(double x, double y)
        //{
        //    return -2 * y;
        //}
        //static double Gdx(double x, double y)
        //{
        //    return y * y * y;
        //}

        //static double Gdy(double x, double y)
        //{
        //    return 3 * x * y * y - 1;
        //}

        static double F(double x, double y)
        {
            return x * x + y * y - 10;
        }
        static double G(double x, double y)
        {
            return Math.Sqrt(x + y) - 2;
        }
        static double Fdx(double x, double y)
        {
            return 2 * x;
        }

        static double Fdy(double x, double y)
        {
            return 2 * y;
        }
        static double Gdx(double x, double y)
        {
            return 1 / (2 * Math.Sqrt(x + y));
        }

        static double Gdy(double x, double y)
        {
            return 1 / (2 * Math.Sqrt(x + y));
        }

    }
}
