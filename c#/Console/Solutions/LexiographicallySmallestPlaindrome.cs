using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class LexiographicallySmallestPlaindrome
    {
        public static string Solution(string s)
        {
            char[] characters = s.ToCharArray(); 
            int left = 0;
            int right = characters.Length-1; 

            while(left < right)
            {
                if (characters[left] != characters[right])
                {
                    if (characters[left] < characters[right])
                    {
                        characters[right] = characters[left];
                    }
                    else
                    {
                        characters[left] = characters[right];
                    }
                }
                left++;
                right--;
            }
            return new string(characters);
        }
    }
}
