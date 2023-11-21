using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises
{
    public class MaxIslandCalculator
    {
        public int CalculateMaxIslandSize(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;

            int maxIslandSize = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int islandSize = DFS(grid, i, j);
                        maxIslandSize = Math.Max(maxIslandSize, islandSize);
                    }
                }
            }

            return maxIslandSize;
        }

        private int DFS(int[][] grid, int row, int col)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            if (row < 0 || row >= rows || col < 0 || col >= cols || grid[row][col] == 0)
                return 0;

            grid[row][col] = 0; // Mark the cell as visited

            int size = 1; // Current cell is part of the island

            // Visit neighboring cells
            size += DFS(grid, row + 1, col);
            size += DFS(grid, row - 1, col);
            size += DFS(grid, row, col + 1);
            size += DFS(grid, row, col - 1);

            return size;
        }
    }
}
