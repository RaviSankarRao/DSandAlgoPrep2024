using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms.Arrays.Easy
{
    internal class MissingNumber
    {
        // https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/2971/

        public static int FindMissingNumber(int[] nums)
        {
            if (nums == null) return -1;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                    return i;
            }

            // Could not find any missing elements. Hence length of the array is the answer
            return nums.Length;
        }

        public static int FindMissingNumberDictionary(int[] nums)
        {
            if (nums == null) return -1;

            // Container of unique elements
            HashSet<int> hashSet = new HashSet<int>();

            foreach (var item in nums)
            {
                hashSet.Add(item);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Contains(i))
                    return i;
            }

            // Could not find any missing elements. Hence length of the array is the answer
            return nums.Length;
        }

        // Bit manipulation - Compress the array down to one variable - Compression algorithms ?
        // XOR -
        //      If one bit is 0 and corresponding bit 1 – result is 1.
        //      Result is 0 for SAME bit type
        // XOR of a number with itself
        // XOR with 0 gives the same number back
        // XOR is commutative
        public static int FindMissingNumberBitManipulation(int[] nums)
        {
            if (nums == null) return -1;

            int expectedXor = 0;
            for (int i = 0; i <= nums.Length; i++)
            {
                expectedXor ^= i;
            }

            int actualXor = 0;
            foreach (var item in nums)
            {
                actualXor ^= item;
            }

            return expectedXor ^ actualXor;
        }

        public static int FindMissingNumberGaussFormula(int[] nums)
        {
            if (nums == null) return -1;

            int expectedSum = 0;
            int actualSum = 0;
            int i = 1;  // To track all natural numbers

            foreach (var item in nums)
            {
                expectedSum += i;
                i++;
                actualSum += item;
            }

            return expectedSum - actualSum;
        }
    }
}
