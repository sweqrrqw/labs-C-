using System;

namespace lab4_var6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Введите размер матрицы: ");
            number = Int32.Parse(Console.ReadLine());
            int [,] matrix = new int[number,number];

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (j == i)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = i + j;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}