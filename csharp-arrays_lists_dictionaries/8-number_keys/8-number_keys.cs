using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        if (myDict == null) {
            return -1;
        }
        int cont = 0;

        foreach (KeyValuePair<string, string> dict in myDict)
        {
            cont++;
        }
        return cont;
    }
}
