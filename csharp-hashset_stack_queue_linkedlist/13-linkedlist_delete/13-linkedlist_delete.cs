using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> holbertonschoolByActual = myLList.First;
        int i = 0;

        while (holbertonschoolByActual != null)
        {
            if (i == index)
            {
                myLList.Remove(holbertonschoolByActual);
                break;
            }
        }
        i++;
        holbertonschoolByActual = holbertonschoolByActual.Next;
    }
}