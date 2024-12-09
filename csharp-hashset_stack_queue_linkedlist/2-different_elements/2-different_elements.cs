using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> different = new List<int>();

        // elements from list 2 that are not in list 1
        foreach (int element in list1)
        {
            if (!list2.Contains(element))
            {
                different.Add(element);
            }
        }
        // same but list 1 and not list 2
        foreach (int element in list2)
        {
            if (!list1.Contains(element))
            {
                different.Add(element);
            }
        }

        different.Sort();
        
        return different;
    }
}