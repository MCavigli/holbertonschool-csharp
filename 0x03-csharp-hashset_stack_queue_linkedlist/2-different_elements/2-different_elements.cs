using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        foreach (int digit in list1)
        {
            if (list2.Contains(digit))
                continue;
            else
                newList.Add(digit);
        }
        foreach (int digit in list2)
        {
            if (list1.Contains(digit))
                continue;
            else
                newList.Add(digit);
        }
        newList.Sort();


        return (newList);
    }
}