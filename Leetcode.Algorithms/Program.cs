using Leetcode.Algorithms.Arrays.Easy;
using Leetcode.Algorithms.LinkedList.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode linkedList = new ListNode(10, new ListNode(21, new ListNode(2, new ListNode())));
            IterateList.PrintList(linkedList);

            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Main ends here");
            Console.WriteLine("--------------");
            Console.ReadLine();
        }
    }
}
