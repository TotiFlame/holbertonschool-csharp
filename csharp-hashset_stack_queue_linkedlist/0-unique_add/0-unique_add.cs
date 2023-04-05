using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> newList = myList.Distinct().ToList();
        int sum = 0;

        foreach (var item in newList)
        {
            sum += item;
        }
        return sum;
    }
}
