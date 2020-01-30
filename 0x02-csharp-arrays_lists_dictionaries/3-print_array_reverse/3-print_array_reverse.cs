using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        int i = array.Length - 1;
        for (; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(array[i]);
                break;
            }
            Console.Write("{0} ", array[i]);
        }
    }
}
