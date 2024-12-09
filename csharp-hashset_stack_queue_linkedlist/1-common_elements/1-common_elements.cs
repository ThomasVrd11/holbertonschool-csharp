using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common = new List<int>();

        foreach (int item in list1)
        {
            if (list2.Contains(item) && !common.Contains(item))
            {
                common.Add(item);
            }
        }

        common.Sort();

        return common;
    }
}
