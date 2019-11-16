using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems
{
    /*
    This problem was asked by Google.

    Given two singly linked lists that intersect at some point, find the intersecting node. The lists are non-cyclical.

    For example, given A = 3-> 7 -> 8 -> 10 and B = 99-> 1 -> 8 -> 10, return the node with value 8.

    In this example, assume nodes with the same value are the exact same node objects.
    */

    class LinkedList
    {
        public static int Intersect(LinkedList<int> l1, LinkedList<int> l2)
        {
            int returnValue = 0;

            if (l1 == null || l2 == null)
                return returnValue;

            LinkedListNode<int> temp1 = l2.First;
            LinkedListNode<int> temp2= l1.First;

            do
            {
                temp2 = l2.First;
                while (temp2 != null)
                {
                    if(temp1.Value == temp2.Value)
                    {
                        return temp1.Value;
                    }
                    temp2 = temp2.Next;
                }

                temp1 = temp1.Next;
            }
            while (temp1 != null);

            return returnValue;
        }
    }
}
