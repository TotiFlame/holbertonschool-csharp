using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> newList;

        newList = List.CreatePrint(0);
        Console.WriteLine("List Length: " + newList.Count);  
    }
}