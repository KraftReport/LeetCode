using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class FindTheOriginalArrayOfPrefixXor
    {
        public static int[] Solution(int[] pref)
        {
            int[] result = new int[pref.Length];
            for(int i = 0; i < pref.Length; i++)
            {
                if (i == 0) result[i] = pref[i];
                else result[i] = pref[i] ^ pref[i - 1];
            }
            return result;
        }
    }
}
