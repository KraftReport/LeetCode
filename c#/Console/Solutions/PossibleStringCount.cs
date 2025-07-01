using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class PossibleStringCount
    {
        public static int Solution(string word)
        {
            var hashMap = new Dictionary<char, int>();

            var result = 1;

            foreach(var character in word)
            {
                if (hashMap.ContainsKey(character))
                {
                    hashMap[character]++;
                }
                else
                {
                    hashMap[character] = 1;
                }
            }

            foreach(var hm in hashMap)
            {
                if (hm.Value > 1)
                { 
                    result = result + hm.Value - 1; 
                }
            }

            return result;
        }
    }
}
