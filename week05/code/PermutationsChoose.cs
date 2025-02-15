using System;
using System.Collections.Generic;

class PermutationsChoose
{
    public static void Permutations(char[] letters, int size, string current, List<string> results)
    {
        if (current.Length == size)
        {
            results.Add(current);
            return;
        }
        foreach (char letter in letters)
        {
            Permutations(letters, size, current + letter, results);
        }
    }

    public static void Main()
    {
        var results = new List<string>();
        Permutations(new char[] {'A', 'B', 'C'}, 2, "", results);
        Console.WriteLine("Permutations(ABC, 2): " + string.Join(", ", results));
    }
}
