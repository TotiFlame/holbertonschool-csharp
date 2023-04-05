using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();
        int i, j;

        for (i = 0; i < list1.Count; i++)
        {
            for (j = 0; j < list2.Count; j++)
            {
                if (list1[i] == list2[j]) {
                    result.Add(list1[i]);
                }
            }
        }
        return result;
    }
}
