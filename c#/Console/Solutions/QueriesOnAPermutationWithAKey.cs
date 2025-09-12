using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class QueriesOnAPermutationWithAKey
    {
        public static int[] Solution(int[] queries,int m)
        {
            int[] result = new int[queries.Length];
            Dictionary<int, int> permutation = new();
            for(int i = 1; i <= m; i++)
            {
                permutation[i] = i-1;
            }
            for(int i =0; i < queries.Length; i++)
            { 
                result[i] = permutation[queries[i]]; 
                foreach(int key in permutation.Keys.ToList())
                {
                    if(permutation[key] < permutation[queries[i]]) permutation[key]++;
                } 
                permutation[queries[i]] = 0;
            }
            return result;
        }
    }
}
