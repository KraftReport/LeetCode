using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class FindTheDifference
    {
        public static char Solution(string s,string t)
        {
            var keyValue = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if (keyValue.ContainsKey(s[i]))
                {
                    keyValue[s[i]]++;
                }
                else
                {
                    keyValue[s[i]] = 1;
                }
            }

            for(int i = 0; i <t.Length; i++)
            {
                if (keyValue.ContainsKey(t[i]))
                {
                    if (keyValue[t[i]] > 1)
                    {
                        keyValue[t[i]]--;
                    }
                    else
                    {
                        keyValue.Remove(t[i]);
                    }
                }
                else
                {
                    return t[i];
                }
            }
            return ' ';
        }
    }
}
