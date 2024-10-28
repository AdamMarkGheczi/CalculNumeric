using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaussian_elimination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti numarul de elemente");
            n = int.Parse(Console.ReadLine());

            float[,,] A = new float[n + 1, n + 1, n + 1];
            float[,] B = new float[n + 1, n + 1];
            float[] X = new float[n + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"Introduceti A[{i},{j}]: ");
                    A[i, j, 1] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Introduceti b[{i}]: ");
                B[i, 1] = int.Parse(Console.ReadLine());
            }



            for (int k = 1; k <= n - 1; k++)
            {
                for (int i = 1; i <= n; i++)
                    for (int j = 1; j <= n; j++)
                    {
                        if (i <= k) A[i, j, k + 1] = A[i, j, k];
                        else if (j <= k) A[i, j, k + 1] = 0;
                        else A[i, j, k + 1] = A[i, j, k] - A[i, k, k] * A[k, j, k] / A[k, k, k];
                            
                    }
                for (int i = 1; i <= n; i++)
                    if (i <= k) B[i, k + 1] = B[i, k];
                    else B[i, k + 1] = B[i, k] - A[i, k, k] * B[k, k] / A[k, k, k];

            }

            X[n] = B[n,n] / A[n, n, n];

            for (int k = n - 1; k >= 1; k--)
            {
                float S = 0;

                for (int i = k + 1; i <= n; i++) S += A[k, i, n] * X[i];

                X[k] = (B[k, n] - S) / A[k, k, n];
            }

            Console.Write("Vectorul X: ");
            for (int i = 1; i <= n; i++) Console.Write($"{X[i]} ");

            Console.ReadLine();
        }
    }
}
