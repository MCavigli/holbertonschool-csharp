using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> newList = new List<bool>();
        int i = 0;
        foreach (int number in myList)
        {
            if (number % 2 == 0)
            {
                newList.Insert(i, true);
                i++;
            }
            else
            {
                newList.Insert(i, false);
                i++;
            }
        }
        return newList;
    }
}