using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        int i = 0, list_len = myList.Count;
        List<bool> result = new List<bool>();

        while (i < list_len)
        {
            if (myList[i] % 2 == 0) {
                result.Add(true);
            } else {
                result.Add(false);
            }
            i++;
        }
        return result;
    }
}
