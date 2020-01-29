﻿using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
        else
        {
            Console.WriteLine();
        }
    }
}