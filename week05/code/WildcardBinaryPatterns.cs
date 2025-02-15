using System;
using System.Collections.Generic;

class WildcardBinaryPatterns
{
    public static void WildcardBinary(string pattern, List<string> results)
    {
        int index = pattern.IndexOf('*');
        if (index == -1)
        {
            results.Add(pattern);
            return;
        }
        WildcardBinary(pattern.Substring(0, index) + '0' + pattern.Substring(index + 1), results);
        WildcardBinary(pattern.Substring(0, index) + '1' + pattern.Substring(index + 1), results);
    }

    public static void Main()
    {
        var results = new List<string>();
        WildcardBinary("1*0*", results);
        Console.WriteLine("WildcardBinary(1*0*): " + string.Join(", ", results));
    }
}
