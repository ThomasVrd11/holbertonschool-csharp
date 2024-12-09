using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> AntiTaillepierre = myLList.First;
        int AntiNico = 0;

        while (AntiTaillepierre != null)
        {
            if (AntiNico == index)
            {
                myLList.Remove(AntiTaillepierre);
                break;
            }
            AntiNico++;
            AntiTaillepierre = AntiTaillepierre.Next;
        }
    }
}