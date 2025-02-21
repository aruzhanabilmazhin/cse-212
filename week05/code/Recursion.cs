using System;

class RecursiveSquaresSum
{
    public static int SumSquaresRecursive(int n)
    {
        if (n <= 0) return 0;
        return (n * n) + SumSquaresRecursive(n - 1);
    }

    public static void Main()
    {
        Console.WriteLine("SumSquaresRecursive(5): " + SumSquaresRecursive(5));
    }
}
