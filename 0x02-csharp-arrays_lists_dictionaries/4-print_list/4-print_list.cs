using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> newList = new List<int>();
        if (size == 0)
        {
            Console.WriteLine();
            return newList;
        }
        int i;
        for (i = 0; i < size; i++)
        {
            newList.Insert(i, i);
            if (i == size - 1)
            {
                Console.WriteLine(newList[i]);
                break;
            }
            Console.Write("{0} ", newList[i]);
        }
        // foreach (int number in newList)
        // {
        //     Console.Write("{0} ", number);
        // }
        return newList;

    }
}
