using System;
using System.Collections.Generic;


class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int counter = 0;
        foreach (int node in myLList)
        {
            if (value == node)
                return (counter);
            counter += 1;
        }
        return (-1);
    }
}
