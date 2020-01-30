using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int i;
        int[] newArray = new int[size];
        for (i = 0; i < newArray.Length; i++)
        {
            newArray[i] = i;
            if (i != newArray.Length - 1)
            {
                Console.Write("{0} ", newArray[i]);
                continue;
            }
            Console.WriteLine(newArray[i]);
        }
        return newArray;
    }
}
