using System;
using System.Collections.Generic;

class List
{

    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        foreach (int digit1 in list1)
        {
            foreach (int digit2 in list2)
            {
                if (digit1 == digit2)
                {
                    newList.Add(digit1);
                }
            }
        }
        return (newList);
    }
}
