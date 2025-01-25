using System;
using System.Collections.Generic;

namespace Week03
{
    public class FindPairs
    {
        public static List<string> FindPairsWithSets(List<string> words)
        {
            HashSet<string> seen = new HashSet<string>();
            List<string> result = new List<string>();

            foreach (string word in words)
            {
                string reverse = word[1].ToString() + word[0].ToString(); // Reverse the two characters in the word
                if (seen.Contains(reverse))
                {
                    result.Add(word + " & " + reverse);
                }
                seen.Add(word);
            }

            return result;
        }

        // Optional: Main method for testing
        public static void Main()
        {
            var words = new List<string> { "am", "at", "ma", "if", "fi" };
            var pairs = FindPairsWithSets(words);
            Console.WriteLine("Symmetric Pairs:");
            foreach (var pair in pairs)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
