using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class SortMatrixByDiagonals
    {
        public static int[][] Solution(int[][] grid)
        {
            int rowLength = grid.Length;

            int columnLength = grid[0].Length;

            int[][] result = new int[grid.Length][];

            Dictionary<int, List<int>> diagonals = new();

            for(int h = 0; h < grid.Length; h++)
            {
                result[h] = new int[grid[h].Length];
            }

            for(int i = 0; i < rowLength; i++)
            {
                for(int j = 0; j < columnLength; j++)
                {
                    int key = i - j;
                    if(!diagonals.ContainsKey(key)) diagonals[key] = new List<int>();
                    diagonals[key].Add(grid[i][j]);
                }
            }

            foreach(KeyValuePair<int,List<int>> diagonal in diagonals)
            {
                if (diagonal.Key < 0) diagonal.Value.Sort();

                if (diagonal.Key >= 0) diagonal.Value.Sort((a, b) => b.CompareTo(a));
            }

            foreach(KeyValuePair<int,List<int>> diagonal in diagonals)
            {
                int key = diagonal.Key;
                int index = 0;

                for (int k = 0; k < rowLength; k++)
                {
                    for (int l = 0; l < columnLength; l++)
                    {
                        if(k-l == key)
                        {
                            result[k][l] = diagonal.Value[index++];
                        }
                    }
                }
            }


 

            return result;
        }
    }
}
