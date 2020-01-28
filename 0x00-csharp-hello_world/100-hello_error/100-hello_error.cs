using System;
using System.Numerics;

namespace _100_hello_error
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitErrorCode = 1;
            Console.Error.WriteLine("and that piece of art is useful - Dora Korpar, 2015-10-19");
            Environment.ExitCode = exitErrorCode;
        }
    }
}