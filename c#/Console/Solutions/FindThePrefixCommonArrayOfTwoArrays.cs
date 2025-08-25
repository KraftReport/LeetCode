using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class FindThePrefixCommonArrayOfTwoArrays
    {
        public static int[] Solution(int[] A, int[] B)
        {
            int[] result = new int[A.Length];

            for(int i = 0; i < A.Length; i++)
            {
                HashSet<int> setA = new HashSet<int>();
                HashSet<int> setB = new HashSet<int>();
                for (int j = 0; j <= i; j++)
                {
                    setA.Add(A[j]);
                    setB.Add(B[j]);
                }
                result[i] = setA.Intersect(setB).Count();
            }

            return result;
        }
    }
}
