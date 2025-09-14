using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class SpiralMatrix3
    {
        public static int[][] Solution(int rows,int cols,int rStart,int cStart)
        {
            int[][] result = new int[rows * cols][];
            int travel = 0;
            int horizontal = 0;
            int vertical = 0; 
            bool goEast = true;
            bool goWest = false;
            bool goSouth = false;
            bool goNorth = false;
            int currentRow = rStart;
            int currentCol = cStart;

            result[travel++] = new int[] { currentRow, currentCol };

            while(travel != result.Length)
            {
                if (goEast)
                {
                    horizontal++; 

                    for(int step = 0; step< horizontal; step++)
                    {
                        currentCol++;
                        if (currentCol >= 0 && currentCol < cols && currentRow >= 0 && currentRow < rows)
                        {
                            result[travel++] = new int[] { currentRow, currentCol };
                            if (travel == result.Length) return result;
                        }
                    }

                    goSouth = true;
                    goEast = false; 
                }

                if (goSouth)
                {
                    vertical++;

                    for (int step = 0; step < vertical; step++)
                    {
                        currentRow++;
                        if (currentCol >= 0 && currentCol < cols && currentRow >= 0 && currentRow < rows)
                        {
                            result[travel++] = new int[] { currentRow, currentCol };
                            if (travel == result.Length) return result;
                        }
                    }

                    goWest = true;
                    goSouth = false;
                }

                if (goWest)
                {
                    horizontal++;

                    for (int step = 0; step < horizontal; step++)
                    {
                        currentCol--;
                        if (currentCol >= 0 && currentCol < cols && currentRow >= 0 && currentRow < rows)
                        {
                            result[travel++] = new int[] { currentRow, currentCol };
                            if (travel == result.Length) return result;
                        }
                    }

                    goNorth = true;
                    goWest = false;
                }

                if (goNorth)
                {
                    vertical++;

                    for (int step = 0; step < vertical; step++)
                    {
                        currentRow--;
                        if (currentCol >= 0 && currentCol < cols && currentRow >= 0 && currentRow < rows)
                        {
                            result[travel++] = new int[] { currentRow, currentCol };
                            if (travel == result.Length) return result;
                        }
                    }


                    goEast = true;
                    goNorth = false;
                }
            }
            return result;
        }
    }
}
