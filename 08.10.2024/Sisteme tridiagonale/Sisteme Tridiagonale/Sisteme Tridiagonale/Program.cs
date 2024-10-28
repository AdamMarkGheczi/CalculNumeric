using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisteme_Tridiagonale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti marimea matricei n: ");
            // indexez de la 0, de aceea am n - 1
            n = int.Parse(Console.ReadLine()) - 1;

            float[] a = new float[n+1];
            float[] b = new float[n+1];
            float[] c = new float[n];
            float[] d = new float[n + 1];
            float[] x = new float[n + 1];

            for (int i = 0; i <= n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"b[{i}]: ");
                b[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write($"c[{i}]: ");
                c[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= n; i++)
            {
                Console.Write($"d[{i}]: ");
                d[i] = int.Parse(Console.ReadLine());
            }

            float[] u = new float[n];
            float[] w = new float[n + 1];
            float[] z = new float[n + 1];

            u[0] = c[0] / a[0];

            for (int i = 1; i <= n - 1; i++)
            { 
                w[i] = a[i] - u[i - 1] * b[i];
                u[i] = c[i] / w[i];
            }

            w[n] = a[n] - u[n - 1] * b[n];
            
            z[0] = d[0] / a[0];
            for (int i = 1; i <= n; i++) z[i] = (d[i] - b[i] * z[i - 1]) / w[i];

            x[n] = z[n];
            for (int i = n - 1; i >= 0; i--) x[i] = z[i] - u[i] * x[i + 1];


            Console.Write("Vectorul X: ");
            for (int i = 0; i <= n; i++) Console.Write($"{x[i]} ");
            Console.ReadLine();
        }
    }
}
