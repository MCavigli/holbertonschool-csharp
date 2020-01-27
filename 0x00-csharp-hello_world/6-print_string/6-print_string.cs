using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine("{0}{0}{0}", str);
        Console.WriteLine(str.Substring(0, 9));
    }
}