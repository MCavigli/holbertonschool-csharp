using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keysToSort = new List<string>();
        foreach (KeyValuePair<string, string> pair in myDict)
            keysToSort.Add(pair.Key);
        keysToSort.Sort();
        foreach (string key in keysToSort)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}