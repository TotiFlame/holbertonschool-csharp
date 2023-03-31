using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        int i = 0, list_length = myList.Count;
        
        if (index > list_length)
        {
            Console.WriteLine("Index out of range");
            return(myList);
        }

        List<int> new_list = new List<int>();

        while (i < list_length)
        {
            if (i == index) {
                i++;
                continue;
            } else {
                // Console.WriteLine("num:" + myList[i]);
                new_list.Add(myList[i]);
            }
            i++;
        }
        // Console.WriteLine("List");
        // foreach(int num in new_list) {
        //     Console.WriteLine(num);
        // }
        // Console.WriteLine("List final");
        return(new_list);
    }
}
