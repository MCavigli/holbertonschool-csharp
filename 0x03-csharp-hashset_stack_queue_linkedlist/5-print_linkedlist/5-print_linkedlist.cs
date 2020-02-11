using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();
        if (size < 0)
            return (newList);
        for (int i = 0; i < size; i++)
            newList.AddLast(i);
        foreach (int node in newList)
            Console.WriteLine(node);
        return (newList);
    }
}
