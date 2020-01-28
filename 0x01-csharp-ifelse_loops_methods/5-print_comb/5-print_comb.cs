using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 99; i++)
            {
                Console.Write("{0}, ", i.ToString("D2"));
            }
            Console.WriteLine(i.ToString("D2"));
        }
    }
}
