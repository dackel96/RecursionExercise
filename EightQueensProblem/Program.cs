using System;

namespace EightQueensProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            int rowCol = int.Parse(Console.ReadLine());

            int[,] matriX = new int[rowCol, rowCol];

            Console.WriteLine(GetQueens(matriX, 0));
        }
        static void Print(int[,] matriX)
        {
            for (int row = 0; row < matriX.GetLength(0); row++)
            {
                for (int col = 0; col < matriX.GetLength(1); col++)
                {
                    if (matriX[row, col] == 1)
                    {
                        Console.Write("|Q|");
                    }
                    if (matriX[row, col] == 0)
                    {
                        Console.Write("|_|");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static int GetQueens(int[,] matriX, int row)
        {
            if (row == matriX.GetLength(0))
            {
                Console.WriteLine("Solved");
                Print(matriX);
                return 1;
            }
            int foundQueens = 0;
            for (int col = 0; col < matriX.GetLength(1); col++)
            {
                if (IsSafe(matriX, row, col))
                {
                    matriX[row, col] = 1;
                    foundQueens += GetQueens(matriX, row + 1);
                    matriX[row, col] = 0;
                }
            }
            return foundQueens;
        }

        private static bool IsSafe(int[,] matriX, int row, int col)
        {
            for (int i = 1; i < matriX.GetLength(0); i++)
            {
                if (row - i >= 0 && matriX[row - i, col] == 1)
                {
                    return false;
                }
                if (col - i >= 0 && matriX[row, col - i] == 1)
                {
                    return false;
                }
                if (row + i < matriX.GetLength(0) && matriX[row + i, col] == 1)
                {
                    return false;
                }
                if (col + i < matriX.GetLength(1) && matriX[row, col + i] == 1)
                {
                    return false;
                }
                if (col + i < matriX.GetLength(0) &&
                    row + i < matriX.GetLength(1) &&
                    matriX[row + i, col + i] == 1)
                {
                    return false;
                }
                if (col - i >= 0 &&
                    row + i < matriX.GetLength(1) &&
                    matriX[row + i, col - i] == 1)
                {
                    return false;
                }
                if (col - i >= 0 &&
                    row - i >= 0 &&
                    matriX[row - i, col - i] == 1)
                {
                    return false;
                }
                if (col + i < matriX.GetLength(0) &&
                    row - i >= 0 &&
                    matriX[row - i, col + i] == 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
