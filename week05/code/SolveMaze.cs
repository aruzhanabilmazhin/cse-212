using System;
using System.Collections.Generic;
using System.Linq;

public class Maze
{
    public List<string> SolveMaze(Maze maze)
    {
        List<string> results = new List<string>();
        List<(int, int)> currPath = new List<(int, int)>();
        SolveMazeHelper(maze, 0, 0, currPath, results);
        return results;
    }

    private void SolveMazeHelper(Maze maze, int x, int y, List<(int, int)> currPath, List<string> results)
    {
        if (!maze.IsValidMove(currPath, x, y))
        {
            return;
        }

        currPath.Add((x, y));

        if (maze.IsEnd(x, y))
        {
            results.Add(currPath.AsString());
            currPath.RemoveAt(currPath.Count - 1); // Backtrack
            return;
        }

        SolveMazeHelper(maze, x + 1, y, currPath, results);
        SolveMazeHelper(maze, x - 1, y, currPath, results);
        SolveMazeHelper(maze, x, y + 1, currPath, results);
        SolveMazeHelper(maze, x, y - 1, currPath, results);

        currPath.RemoveAt(currPath.Count - 1); // Backtrack
    }
}

//Extension Method for List<(int, int)> to string conversion
public static class ListExtensions
{
    public static string AsString(this List<(int, int)> path)
    {
        return string.Join("->", path.Select(p => $"({p.Item1},{p.Item2})"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Problem5 p5 = new Problem5();
        Console.WriteLine("\nProblem 5:");

        // Example Maze Usage (Small Maze)
        int[] mazeData = { 1, 1, 1, 0, 1, 0, 1, 1, 2 };
        Maze maze = new Maze(3, 3, mazeData); // Width, Height, Data
        List<string> mazeSolutions = p5.SolveMaze(maze);
        foreach (string solution in mazeSolutions)
        {
            Console.WriteLine(solution);
        }

        // Example Maze Usage (Big Maze - Example)
        int[] bigMazeData = {
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1,
            1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1,
            1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1,
            1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, // End at (18, 8)
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1
        };

        Maze bigMaze = new Maze(20, 10, bigMazeData);
        List<string> bigMazeSolutions = p5.SolveMaze(bigMaze);
        foreach (string solution in bigMazeSolutions)
        {
            Console.WriteLine(solution);
        }

    }
}