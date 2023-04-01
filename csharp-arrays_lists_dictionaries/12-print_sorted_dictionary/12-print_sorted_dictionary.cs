using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDict = myDict.OrderBy(x => x.Key);
        foreach (var each in sortedDict)
        {
            Console.WriteLine(each.Key + ": " + each.Value);
        }
    }
}
