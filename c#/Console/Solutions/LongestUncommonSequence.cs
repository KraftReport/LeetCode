using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class LongestUncommonSequence
    {
        public static int Solution(string a, string b)
        {
            var result = -1;

            var baseLength = a.Length >= b.Length ? a.Length : b.Length;

            for(var i = 0; i < baseLength; i++)
            {
                if(i < a.Length && i < b.Length)
                {
                    if (a[i] != b[i])
                    {
                        if(a.Length >= b.Length)
                        {
                            return a.Length;
                        }
                        else
                        {
                            return b.Length;
                        } 
                    }
                }
                else
                {
                    if (a.Length >= b.Length)
                    {
                        return a.Length;
                    }
                    else
                    {
                        return b.Length;
                    }
                }
            }
            return result;
        }
    }
}
