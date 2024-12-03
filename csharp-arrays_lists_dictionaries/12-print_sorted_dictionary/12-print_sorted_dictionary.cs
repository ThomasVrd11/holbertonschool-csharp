using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.keys)
        keys.Sort();

        foreach (string ikey in keys)
        {
            Console.WriteLine("{0}: {1}", ikey, myDict[key]);
        }
    }
}