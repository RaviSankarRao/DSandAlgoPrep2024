using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms.LinkedList.Basics
{
    public class InserNode
    {
        public ListNode InsertAtBegining(ListNode head, int val)
        {
            // Create new node
            var newNode = new ListNode(val);

            // Point new node's next to current head
            newNode.next = head;

            // Since it is added at begining, new node will be head.
            // Hence retrun new node
            return newNode;
        }

        public ListNode InsertAtEnd(ListNode head, int val)
        {
            // Create new node
            var newNode = new ListNode(val);

            if (head != null)
            {
                var currentNode = head;

                // Traverse till the end of the list
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }

                currentNode.next = newNode;
            } 
            else
            {
                head = newNode;
            }

            // Since new node is added at the end, head will remain same
            return head;
        }
    }
}
