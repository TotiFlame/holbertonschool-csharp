using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> each in myDict) {
            newDict.Add(each.Key, each.Value * 2);
        }
        return newDict;
    }
}
