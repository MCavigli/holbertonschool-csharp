using System;

class Program
{
	static void Main(string[] args)
        {
		float number = 3.14159f;
        Console.WriteLine("Float: " + MathF.Round(number * 100f) / 100f);
        }
}