using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
        {
            number *= -1;
        }
        Console.Write(number % 10);
        return (number % 10);
    }
}

