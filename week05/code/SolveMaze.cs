using System;
using System.Collections.Generic;

class MazeSolver
{
    public static void SolveMaze(int[,] maze, int x, int y, List<(int, int)> currPath, List<string> results)
    {
        int n = maze.GetLength(0);
        if (x < 0 || x >= n || y < 0 || y >= n || maze[x, y] == 0 || currPath.Contains((x, y)))
            return;

        currPath.Add((x, y));
        if (maze[x, y] == 2)
        {
            results.Add(string.Join(" -> ", currPath));
            currPath.RemoveAt(currPath.Count - 1);
            return;
        }

        SolveMaze(maze, x + 1, y, currPath, results);
        SolveMaze(maze, x - 1, y, currPath, results);
        SolveMaze(maze, x, y + 1, currPath, results);
        SolveMaze(maze, x, y - 1, currPath, results);

        currPath.RemoveAt(currPath.Count - 1);
    }

    public static void Main()
    {
        int[,] maze = {
            {1, 1, 0},
            {0, 1, 2},
            {0, 0, 1}
        };
        var results = new List<string>();
        SolveMaze(maze, 0, 0, new List<(int, int)>(), results);
        Console.WriteLine("Maze solutions: " + string.Join(" | ", results));
    }
}
