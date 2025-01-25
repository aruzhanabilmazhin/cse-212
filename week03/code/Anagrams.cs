using System;
using System.Collections.Generic;

namespace Week03
{
    public class IsAnagram
    {
        public static bool AreAnagrams(string word1, string word2)
        {
            // If lengths are not the same, they cannot be anagrams
            if (word1.Length != word2.Length) return false;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count characters for word1 (ignoring case and spaces)
            foreach (char c in word1.ToLower().Replace(" ", ""))
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Decrease character count for word2 (ignoring case and spaces)
            foreach (char c in word2.ToLower().Replace(" ", ""))
            {
                if (!charCount.ContainsKey(c)) return false; // Character doesn't exist in word1
                charCount[c]--;
                if (charCount[c] < 0) return false; // More occurrences in word2 than in word1
            }

            return true; // If we passed all checks, they are anagrams
        }

        // Optional: Main method for testing
        public static void Main()
        {
            string word1 = "CAT", word2 = "ACT";
            Console.WriteLine($"Are '{word1}' and '{word2}' anagrams? {AreAnagrams(word1, word2)}");
        }
    }
}
