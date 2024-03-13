using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms.LinkedList.Basics
{
    public  class DLLNode
    {
        public int val;
        public DLLNode next;
        public DLLNode previous;

        public DLLNode(int val = 0, DLLNode next = null, DLLNode previous = null)
        {
            this.val = val;
            this.next = next;
            this.previous = previous;
        }
    }
}
