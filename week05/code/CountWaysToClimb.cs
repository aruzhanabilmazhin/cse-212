using System;
using System.Collections.Generic;

class ClimbingStairs
{
    public static int CountWaysToClimb(int s, Dictionary<int, int> memo)
    {
        if (s < 0) return 0;
        if (s == 0) return 1;
        if (memo.ContainsKey(s)) return memo[s];

        int result = CountWaysToClimb(s - 1, memo) + CountWaysToClimb(s - 2, memo) + CountWaysToClimb(s - 3, memo);
        memo[s] = result;
        return result;
    }

    public static void Main()
    {
        var memo = new Dictionary<int, int>();
        Console.WriteLine("CountWaysToClimb(4): " + CountWaysToClimb(4, memo));
    }
}
