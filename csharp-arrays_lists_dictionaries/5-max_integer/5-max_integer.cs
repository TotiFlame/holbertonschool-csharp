using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int max, i = 0, list_len = myList.Count;

        max = myList[0];
        while (i < list_len)
        {
            if (max < myList[i]) {
                max = myList[i];
            }
            i++;
        }
        return max;
    }
}
