using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        while (current != null)
        {
            if (n < current.Next.Value)
            {
                myLList.AddAfter(current, n);
                return (current);
            }
            current = current.Next;
        }
        return (current);
    }
}
