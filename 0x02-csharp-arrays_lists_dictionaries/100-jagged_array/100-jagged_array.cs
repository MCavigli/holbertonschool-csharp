using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] {0, 1, 2, 3};
            jaggedArr[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
            jaggedArr[2] = new int[] {0, 1};

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j <jaggedArr[i].Length; j++)
                {
                    Console.Write("{0}{1}", jaggedArr[i][j], j == (jaggedArr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}
