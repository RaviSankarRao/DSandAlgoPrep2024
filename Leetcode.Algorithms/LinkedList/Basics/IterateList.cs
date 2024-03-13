using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms.LinkedList.Basics
{
    public static class IterateList
    {
        public static void PrintList(ListNode head)
        {
            var current = head;

            while (current != null)
            {
                Console.WriteLine(current.val + " ");

                // got to next node
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
