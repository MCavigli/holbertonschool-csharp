using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int counter = 0;
        foreach (KeyValuePair<string, string> kv in myDict)
            counter++;
        return counter;
    }
}