﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int counter = 0;
        foreach (int node in myLList)
            counter += 1;
        return (counter);
    }
}
