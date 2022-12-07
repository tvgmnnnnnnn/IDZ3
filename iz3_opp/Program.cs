using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz3_opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M > ");
            int M = int.Parse(Console.ReadLine());

            Console.Write("Введите значение N > ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float[,] matrix = new float[M,N];
            int x = 0;
            
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    x = x + 1;
                    Console.Write("Введите " + (x) + "-е число > ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Исзодная матрица: ");
            Console.WriteLine(" ");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine(" ");
            }

            float SrAr = 0, Sum = 0;
            int z = 0;


            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Sum = Sum + matrix[i, j];
                }
                z = z + 1;
                SrAr = Sum / N;
                Console.WriteLine(" ");
                if (z != 3)
                    Console.WriteLine("Среднеарифметическое " + (z) + "-ой строки: " + (SrAr));
                else
                    Console.WriteLine("Среднеарифметическое " + (z) + "-ей строки: " + (SrAr));
                SrAr = 0;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Результирующая матрица: ");
            Console.WriteLine(" ");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
        }
    }
}
