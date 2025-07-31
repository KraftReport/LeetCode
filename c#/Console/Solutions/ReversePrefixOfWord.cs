using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class ReversePrefixOfWord
    {
        public static string Solution(string word,char ch)
        {
            char[] characters = word.ToCharArray();

            for(int i = 0; i < characters.Length; i++)
            {
                int firstPointer = 0;
                int secondPointer = i;
                if (characters[secondPointer] == ch)
                {
                    while (firstPointer <= secondPointer)
                    {
                        char temp = characters[firstPointer];
                        characters[firstPointer] = characters[secondPointer];
                        characters[secondPointer] = temp;
                        firstPointer++;
                        secondPointer--;
                    }
                    return new string(characters);
                }
            }

            return word;
        }
    }
}
