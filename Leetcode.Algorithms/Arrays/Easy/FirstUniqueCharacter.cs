using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms.Arrays.Easy
{
    internal class FirstUniqueCharacter
    {
        /*
            Console.WriteLine(FirstUniqChar("leetcode")); // 0
            Console.WriteLine(FirstUniqChar("loveleetcode")); // 2
            Console.WriteLine(FirstUniqChar("aabb")); // -1
            Console.WriteLine(FirstUniqChar("dddccdbba")); // 8
         */
        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;

            if (s.Length == 1) return 0;

            Dictionary<char, int> charactersInString = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charactersInString.ContainsKey(c))
                {
                    // Increase count by 1
                    charactersInString[c]++;
                }
                else
                {
                    // Add char to dictionary
                    charactersInString.Add(c, 1);
                }
            }

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (charactersInString[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
