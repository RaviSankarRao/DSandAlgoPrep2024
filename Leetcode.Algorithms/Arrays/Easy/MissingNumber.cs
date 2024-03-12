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

        public static int FindMissingNumberBitManipulation(int[] nums)
        {
            if (nums == null) return -1;

            int missing = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                missing ^= i ^ nums[i];
            }

            return missing;
        }
    }
}
