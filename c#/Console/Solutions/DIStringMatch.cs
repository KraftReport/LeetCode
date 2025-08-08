using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class DIStringMatch
    {
        public static int[] Solution(string s)
        {
            int[] result = new int[s.Length + 1];
            int low = 0;
            int high = s.Length;
            int index = 0;
            
            while(low <= high)
            {
                if(low == high)
                {
                    result[index] = low;
                    break;
                }

                if (s[index] == 'I')
                {
                    result[index] = low;
                    low++;
                    index++;
                    continue;
                }

                if (s[index] == 'D')
                {
                    result[index] = high;
                    high--;
                    index++;
                    continue;
                }
            }  
            return result;
        }
    }
}
