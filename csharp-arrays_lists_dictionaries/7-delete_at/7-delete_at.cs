using System;
using System.Collections.Generic;


class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        int list_length = myList.Count;
        
        if (index >= list_length || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return(myList);
        }
        myList.Remove(myList[index]);
        return(myList);
    }
}
