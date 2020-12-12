using System;
using System.Diagnostics;

namespace lab4_var6
{
    internal class Program
    {
      
        public static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            Random random_number = new Random();
            int numbers;
            Console.Write("Введите размер массива: ");
            numbers = Int32.Parse(Console.ReadLine());
            int[] mass1 = new int[numbers];
            int[,] mass2 = new int[numbers,numbers];
            int[][] mass3 = new int[numbers][];
            for (int i = 0; i < numbers; i++)
            {
                mass3[i] = new int[numbers];
            }

            time.Start();
            for (int i = 0; i < numbers; i++)
            {
                mass1[i] = random_number.Next(0, 9);
                Console.Write(mass1[i]+" ");
            }
            time.Stop();
            Console.WriteLine();
            Console.WriteLine(time.Elapsed);
            time.Reset();
            Console.WriteLine("Генерирую второй массив");
            Console.ReadKey();
            time.Start();
            for (int i = 0; i < numbers; i++)
            {
                for (int j = 0; j < numbers; j++)
                {
                    mass2[i,j] = random_number.Next(0,9);
                    Console.Write(mass2[i,j]+" ");
                    
                }
                Console.WriteLine();
            }
            time.Stop();
            Console.WriteLine();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine("Генерирую третий массив");
            time.Reset();
            Console.ReadKey();
            time.Start();
            for (int i = 0; i < mass3.Length; i++)
            {
                for (int j = 0; j < mass3[i].Length; j++)
                {
                    mass3[i][j] = random_number.Next(0, 9);
                    Console.Write(mass3[i][j]+" ");
                }
                Console.WriteLine();
            }

            time.Stop();
            Console.WriteLine(time.Elapsed);
        }
        
    }
}