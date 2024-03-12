using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms.Arrays.Easy
{
    internal class MostCommonWord
    {
        /*
            Console.WriteLine(MostCommonWord.FindMostCommonWordStringBuilder("Bob hit a ball, the hit BALL flew far after it was hit", new string[] { "hit" }));  // ball
            Console.WriteLine(MostCommonWord.FindMostCommonWordStringBuilder("a.", new string[] { }));   // a
            Console.WriteLine(MostCommonWord.FindMostCommonWordStringBuilder("Bob", new string[] { }));  // bob
            Console.WriteLine(MostCommonWord.FindMostCommonWordStringBuilder("Bob. hIt, baLl", new string[] { "bob", "hit" }));  // ball

         */

        public static string FindMostCommonWord(string paragraph, string[] banned)
        {
            if (paragraph == null) return null;

            string word = string.Empty;
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Add each word to the dictionary
            foreach (var character in paragraph)
            {
                // Add only valid alphabets
                if (Char.IsLetter(character))
                {
                    word += character;
                }
                else if (!string.IsNullOrEmpty(word))
                {
                    word = word.ToLower();

                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount.Add(word, 1);
                    }

                    word = string.Empty;
                }
            }

            // Add the last word to the dictionary
            if (!string.IsNullOrEmpty(word))
            {
                word = word.ToLower();
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            // Iterate banned words and remove it from the dictionary
            foreach (var item in banned)
            {
                if (wordCount.ContainsKey(item)) 
                {
                    wordCount.Remove(item);
                }
            }

            // Iterate dictionary to find the max occured word
            int maxCount = 0;
            string maxCountWord = string.Empty;

            foreach (var item in wordCount)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    maxCountWord = item.Key;
                }
            }

            return maxCountWord;
        }

        public static string FindMostCommonWordStringBuilder(string paragraph, string[] banned)
        {
            if (paragraph == null) return null;

            StringBuilder word = new StringBuilder();
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Add each word to the dictionary
            foreach (var character in paragraph)
            {
                // Add only valid alphabets
                if (char.IsLetter(character))
                {
                    word.Append(character);
                }
                else if (!string.IsNullOrEmpty(word.ToString()))
                {
                    string lowerWord = word.ToString().ToLower();
                    if (wordCount.ContainsKey(lowerWord))
                    {
                        wordCount[lowerWord]++;
                    }
                    else
                    {
                        wordCount.Add(lowerWord, 1);
                    }

                    word = new StringBuilder();
                }
            }

            // Add the last word to the dictionary
            if (!string.IsNullOrEmpty(word.ToString()))
            {
                string lowerWord = word.ToString().ToLower();
                if (wordCount.ContainsKey(lowerWord))
                {
                    wordCount[lowerWord]++;
                }
                else
                {
                    wordCount.Add(lowerWord, 1);
                }
            }

            // Iterate banned words and remove it from the dictionary
            foreach (var item in banned)
            {
                if (wordCount.ContainsKey(item))
                {
                    wordCount.Remove(item);
                }
            }

            // Iterate dictionary to find the max occured word
            int maxCount = 0;
            string maxCountWord = string.Empty;

            foreach (var item in wordCount)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    maxCountWord = item.Key;
                }
            }

            return maxCountWord;
        }
    }
}
