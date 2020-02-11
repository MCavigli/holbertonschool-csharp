using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList == null)
            return (null);
        LinkedListNode<int> current = myLList.First;
        if (current.Next == null)
        {
            if (current.Value > n)
            {
                myLList.AddFirst(n);
                return (myLList.First);
            }
            else
            {
                myLList.AddLast(n);
                return (myLList.Last);
            }
        }
        while (current != null)
        {

            if (n > current.Value && current.Next == null)
            {
                myLList.AddLast(n);
                return (current);
            }
            if (n < current.Next.Value && n > current.Value)
            {
                myLList.AddAfter(current, n);
                return (current);
            }
            current = current.Next;
        }
        return (current);
    }
}
