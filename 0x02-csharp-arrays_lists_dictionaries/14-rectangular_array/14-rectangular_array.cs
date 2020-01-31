using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dArray = new int[5, 5] { 
                {0, 0, 0, 0, 0}, 
                {0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0}, 
                {0, 0, 0, 0, 0}
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("{0}", dArray[i, j]);
                        continue;
                    }
                    Console.Write(" {0}", dArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
