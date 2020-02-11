using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        if (current == null || n < current.Value)
        {
            myLList.AddFirst(newNode);
            return (newNode);
        }
        if (current.Next == null && current.Value < n)
        {
            myLList.AddLast(newNode);
            return (newNode);
        }
        while (current.Next != null)
        {
            if (current.Next.Value >= n)
                break;
            current = current.Next;
        }
        myLList.AddAfter(current, newNode);
        return (newNode);
    }
}
