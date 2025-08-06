using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class ReverseString
    {
        public static string Solution(string s)
        {
            string result = string.Empty; 
            string[] strings = s.Split(' ');

            for(int i = 0; i < strings.Length; i++)
            {
                char[] chars = strings[i].ToCharArray(); 
                int start = 0; 
                int end = chars.Length - 1;
                 
                while (start <= end)
                {
                    (chars[end], chars[start]) = (chars[start], chars[end]);  
                    start++; 
                    end--;  
                } 

                result += new string(chars);
                
                if(i < strings.Length -1) result += " ";
            }
            return result;
        }
    }
}
