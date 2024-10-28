using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisteme_superior_triunghiulare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti numarul de elemente");
            n = int.Parse(Console.ReadLine());

            float[,] A = new float[n+1, n+1];
            float[] B = new float[n + 1];
            float[] X = new float[n + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                { 
                    Console.Write($"Introduceti A[{i},{j}]: ");
                    A[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 1;i <= n; i++) 
            {
                Console.Write($"Introduceti b[{i}]: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            X[n] = B[n] / A[n, n];

            for (int k = n-1; k >= 1; k--)
            {
                float S = 0;

                for (int i = k + 1; i <= n; i++) S += A[k, i] * X[i];

                X[k] = (B[k] - S) / A[k, k];
            }

            Console.Write("Vectorul X: ");
            for (int i = 1; i <= n; i++) Console.Write($"{X[i]} ");

            Console.ReadLine();
        }
    }
}
