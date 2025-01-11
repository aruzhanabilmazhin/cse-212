using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of size 'length' to store the multiples.
        double[] multiples = new double[length];

        // Step 2: Loop through the array to calculate each multiple.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Multiply 'number' by (i + 1) to generate the multiple.
            multiples[i] = number * (i + 1);
        }

        // Step 4: Return the filled array.
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'. For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3, the result should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}. 
    /// The value of 'amount' will be in the range of 1 to data.Count, inclusive.
    ///
    /// This function modifies the original list in place.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Calculate the actual rotation index using modulo (%).
        // This ensures the rotation wraps correctly even if the amount exceeds the size of the list.
        int rotationIndex = data.Count - (amount % data.Count);

        // Step 2: Use slicing to get the two parts of the list.
        // First part: from rotationIndex to the end of the list.
        List<int> part1 = data.GetRange(rotationIndex, data.Count - rotationIndex);

        // Second part: from the start of the list to rotationIndex.
        List<int> part2 = data.GetRange(0, rotationIndex);

        // Step 3: Clear the original list.
        data.Clear();

        // Step 4: Rebuild the list by appending part1 and part2 in the correct order.
        data.AddRange(part1);
        data.AddRange(part2);
    }
}
