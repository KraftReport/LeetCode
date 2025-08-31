using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class QueriesOnNumberOfPointsInsideTheCircle
    {
        public static int[] Solution(int[][] points, int[][] queries)
        {
            int[] result = new int[queries.Length];
            for (int i = 0; i < points.Length; i++)
            {
                int px = points[i][0];
                int py = points[i][1];
                for (int j = 0; j < queries.Length; j++)
                {
                    int qx = queries[j][0];
                    int qy = queries[j][1];
                    int qr = queries[j][2];

                    if((px-qx) * (px - qx) + (py - qy) * (py - qy) <= qr * qr)
                    {
                        result[j]++;
                    }
                }
            }
            return result;
        }
    }
}
