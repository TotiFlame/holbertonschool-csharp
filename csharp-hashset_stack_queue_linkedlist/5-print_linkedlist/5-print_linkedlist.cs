using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            LinkedList<int> newLinkedList = new LinkedList<int>();
            return newLinkedList;
        }
        LinkedList<int> myLinkedList = new LinkedList<int>();
        int i;
        for (i = 0; i < size; i++)
        {
            myLinkedList.AddLast(i);
            Console.WriteLine("{0}", i);
        }
        return myLinkedList;
    }
}
