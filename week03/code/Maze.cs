public class Maze
{
    private Dictionary<(int, int), (bool left, bool right, bool up, bool down)> maze;
    private (int x, int y) currentPosition;

    public Maze(Dictionary<(int, int), (bool, bool, bool, bool)> maze, (int, int) startPosition)
    {
        this.maze = maze;
        this.currentPosition = startPosition;
    }

    public (int x, int y) MoveLeft()
    {
        if (maze[currentPosition].left)
        {
            currentPosition = (currentPosition.x - 1, currentPosition.y);
        }
        return currentPosition;
    }

    public (int x, int y) MoveRight()
    {
        if (maze[currentPosition].right)
        {
            currentPosition = (currentPosition.x + 1, currentPosition.y);
        }
        return currentPosition;
    }

    public (int x, int y) MoveUp()
    {
        if (maze[currentPosition].up)
        {
            currentPosition = (currentPosition.x, currentPosition.y + 1);
        }
        return currentPosition;
    }

    public (int x, int y) MoveDown()
    {
        if (maze[currentPosition].down)
        {
            currentPosition = (currentPosition.x, currentPosition.y - 1);
        }
        return currentPosition;
    }
}
