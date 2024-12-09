using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> nodeStart = new LinkedListNode<int>(n);
        myLList.AddFirst(nodeStart);
        return nodeStart;
    }
}