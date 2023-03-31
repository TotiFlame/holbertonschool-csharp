using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        foreach (KeyValuePair<string, string> cada_uno in myDict)
        {
            if (key == cada_uno.Key) {
                myDict[cada_uno.Key] = value;
                return myDict;
            }
        }
        myDict.Add(key, value);
        return myDict;
    }
}
