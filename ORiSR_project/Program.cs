using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ORiSR_project
{
    class Program
    {
            static void Main(string[] args)
            {
                simpleFor();
                //parallelFor();
            }

            public static void parallelFor()
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int number = 15000; //wybranie wielkości macierzy 
                int[,] matrix = new int[number, number];
                Random rand = new Random();
                //generowanie
                Parallel.For(0, number, i =>
                {
                    for (int j = 0; j < number; j++)
                    {
                        matrix[i, j] = rand.Next(10, 99);
                    }
                });
                //transponowanie
                int[,] matrix2 = new int[number, number];
                Parallel.For(0, number, i =>
                {
                    for (int j = 0; j < number; j++)
                    {
                        matrix2[i, j] = matrix[j, i];
                    }
                });
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds);
            }

            public static void simpleFor()
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                int number = 15000;//wybranie wielkości macierzy 
            int[,] matrix = new int[number, number];

                //generowanie
                Random rand = new Random();
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        matrix[i, j] = rand.Next(10, 99);
                    }
                }
                //transponowanie
                int[,] matrix2 = new int[number, number];
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        matrix2[i, j] = matrix[j, i];
                    }
                }
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds);
            }
        }
}
