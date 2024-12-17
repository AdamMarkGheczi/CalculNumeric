using System;


namespace Celor_mai_mici_patrate
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

            double a = 0, b = 0, S1=0, S2=0, T1=0, T2 = 0;

            for (int i = 0; i <= n; i++)
            {
                S1 = S1 + x[i];
                S2 = S2 + x[i] * x[i];
                T1 = T1 + y[i];
                T2 = T2 + x[i] * y[i];
            }

            double d = (n + 1) * S2 - S1 * S1;
            double d1 = (n + 1) * T2 - S1 * T1;
            double d2 = S2 * T1 - T2 * S1;

            a = d1 / d;
            b = d2 / d;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadLine();
        }

    }
}
