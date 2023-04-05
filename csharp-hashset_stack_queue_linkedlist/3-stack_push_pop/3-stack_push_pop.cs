using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        string top = aStack.Peek();
        bool contains = aStack.Contains(search);

        Console.WriteLine("Number of items: {0}", aStack.Count);
        Console.WriteLine("Top Item: {0}", top);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, contains);
        
        while (aStack.Contains(search))
        {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
