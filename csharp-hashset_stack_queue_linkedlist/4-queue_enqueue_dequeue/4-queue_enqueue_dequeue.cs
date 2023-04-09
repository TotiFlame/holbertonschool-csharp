using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
        {
            Console.WriteLine("Queue is empty");
        }
        string top = aQueue.Peek();
        bool found = aQueue.Contains(search);

        Console.WriteLine("Number of items: {0}", aQueue.Count);
        Console.WriteLine("First item: {0}", top);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, found);
        while (aQueue.Contains(search))
        {
            aQueue.Dequeue();
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
