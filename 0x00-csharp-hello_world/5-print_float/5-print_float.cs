using System;

class Program
{
	static void Main(string[] args)
        {
		float number = 3.14159f;
        Console.WriteLine("Float: {0}", MathF.Round(number * 100f) / 100f);
        }
}