using Leetcode.Algorithms.Arrays.Easy;
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
            Console.WriteLine(MissingNumber.FindMissingNumberBitManipulation(new int[] { 3, 0, 1 }));  // 2
            Console.WriteLine(MissingNumber.FindMissingNumberBitManipulation(new int[] { 0, 1 }));     // 2
            Console.WriteLine(MissingNumber.FindMissingNumberBitManipulation(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));        // 8
            Console.WriteLine(MissingNumber.FindMissingNumberBitManipulation(new int[] { }));

            Console.ReadLine();
        }
    }
}
