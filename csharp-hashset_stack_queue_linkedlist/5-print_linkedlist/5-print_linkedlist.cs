﻿using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list2 = new LinkedList<int>();

        if (size < 0)
        {
            return list2
        }

        for (int i = 0; i < size; i++)
        {
            list2.AddLast(i);
            System.Console.WriteLine(i);
        }

        return list2;
    }
}