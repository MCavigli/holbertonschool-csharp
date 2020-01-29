using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i = 0; i <= 8; i++)
            {
                for (j = i + 1; j <= 9; j++)
                {
                    Console.Write("{0}{1}", i, j);
                    if (i == 8 && j == 9)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
