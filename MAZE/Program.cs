using System;

namespace MAZE
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] maze = new string[]
            //{
            //    "0101000000",
            //    "0100101010",
            //    "0001001010",
            //    "0010010010",
            //    "00001E0010"
            //};
            string[] maze = new string[]
            {
                "0110E",
                "01000",
                "00010",
                "01000"
            };
            Print(maze);
            FindPaths(maze, 0, 0, new bool[maze.Length, maze[0].Length], "");
        }

        private static void FindPaths(string[] maze, int row, int col, bool[,] visited, string path)
        {
            if (maze[row][col] == 'E')
            {
                Console.WriteLine(path);
                return;
            }
            visited[row, col] = true;
            if (IsSafe(maze, row - 1, col, visited))
            {
                FindPaths(maze, row - 1, col, visited, path + "U");
            }
            if (IsSafe(maze, row + 1, col, visited))
            {
                FindPaths(maze, row + 1, col, visited, path + "D");
            }
            if (IsSafe(maze, row, col - 1, visited))
            {
                FindPaths(maze, row, col - 1, visited, path + "L");
            }
            if (IsSafe(maze, row, col + 1, visited))
            {
                FindPaths(maze, row, col + 1, visited, path + "R");
            }
           visited[row, col] = false;
        }
        private static bool IsSafe(string[] maze, int row, int col, bool[,] visited)
        {
            if (row < 0 || col < 0 || row >= maze.Length || col >= maze[0].Length)
            {
                return false;
            }
            if (maze[row][col] == '1' || visited[row, col])
            {
                return false;
            }
            return true;
        }
        private static void Print(string[] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
