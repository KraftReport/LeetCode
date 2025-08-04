using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class FirstPlanedrome
    {
        public static string Solution(string[] words)
        { 
            for(int i = 0; i < words.Length; i++)
            { 
                int first = 0;
                int last = words[i].Length - 1;
                int count = 0;
                while(first <= last)
                {
                    if (words[i][first] == words[i][last])
                    {
                        count++;
                        if (first != last) count++; 
                    }
                    first++;
                    last--;
                }
                if (count == words[i].Length) return words[i];
            }
            return string.Empty;
        }
    }
}
