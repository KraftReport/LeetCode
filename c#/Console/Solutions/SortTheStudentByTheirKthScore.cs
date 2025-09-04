using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class SortTheStudentByTheirKthScore
    {
        public static int[][] Solution(int[][] score,int k)
        {
            int[][] result = new int[score.Length][];
            for(int i = 0; i < score.Length; i++)
            {
                for(int j = i+1; j < score.Length; j++)
                { 
                    if (score[i][k] < score[j][k])
                    {
                        (score[j], score[i]) = (score[i], score[j]);
                    }
                }
                result[i] = score[i];
            }
            return result;
        }
    }
}
