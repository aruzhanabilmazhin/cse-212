using System;
using System.Collections.Generic;
using System.IO;

namespace Week03
{
    public class SummarizeDegrees
    {
        public static Dictionary<string, int> SummarizeDegreesFromFile(string filePath)
        {
            Dictionary<string, int> degreeCounts = new Dictionary<string, int>();

            foreach (var line in File.ReadLines(filePath))
            {
                var columns = line.Split(',');

                if (columns.Length >= 4)
                {
                    string degree = columns[3].Trim(); // Assuming the degree is in the 4th column
                    if (degreeCounts.ContainsKey(degree))
                    {
                        degreeCounts[degree]++;
                    }
                    else
                    {
                        degreeCounts[degree] = 1;
                    }
                }
            }

            return degreeCounts;
        }

        // Optional: Main method for testing
        public static void Main()
        {
            string filePath = "census.txt";  // Replace with your actual file path
            var degreeSummary = SummarizeDegreesFromFile(filePath);
            Console.WriteLine("Degree Summary:");
            foreach (var entry in degreeSummary)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
