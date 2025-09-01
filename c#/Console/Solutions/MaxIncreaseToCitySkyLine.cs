using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class MaxIncreaseToCitySkyLine
    {
        public static int Solution(int[][] grid)
        {
            int result = 0; 
            int row = 0;
            int column = 0;

            while(row < grid.Length && column < grid.Length)
            { 
                int rCurrent = grid[row][column];
                int cCurrent = grid[row][column];

                for (int c = 0; c < grid.Length; c++)
                {
                    if (grid[row][c] > rCurrent) rCurrent = grid[row][c];
                    if (grid[c][column] > cCurrent) cCurrent = grid[c][column];
                }
                
                result += (rCurrent < cCurrent ? rCurrent : cCurrent) - grid[row][column];

                if (column == grid.Length - 1)
                {
                    column = 0;
                    row++;
                }
                else
                {
                    column++;
                }
            }
            return result;
        }
    }
}
