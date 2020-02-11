using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool present = aQueue.Contains(search);
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());
        aQueue.Enqueue(newItem);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, present);
        if (present == true)
        {
            while (aQueue.Dequeue() != search)
            { }
        }
        return (aQueue);
    }
}
