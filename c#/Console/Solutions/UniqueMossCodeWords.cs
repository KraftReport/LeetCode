using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class UniqueMossCodeWords
    {
        public static int Solution(string[] words)
        {
            Dictionary<char,string> mossCodes = new Dictionary<char, string>
            {
                {'a', ".-"},{'b', "-..."},{'c', "-.-."},{'d', "-.."},{'e', "."},
                {'f', "..-."},{'g', "--."},{'h', "...."},{'i', ".."},{'j', ".---"},
                {'k', "-.-"},{'l', ".-.."},{'m', "--"},{'n', "-."},{'o', "---"},
                {'p', ".--."},{'q', "--.-"},{'r', ".-."},{'s', "..."},{'t', "-"},
                {'u', "..-"},{'v', "...-"},{'w', ".--"},{'x', "-..-"},{'y', "-.--"},{'z', "--.."}
            };

            Dictionary<string , int> uniqueMossCodeCombinations = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string mossCodeComibnation = string.Empty;

                foreach (char character in word)
                {
                    mossCodeComibnation += mossCodes[character];
                }

                if (uniqueMossCodeCombinations.ContainsKey(mossCodeComibnation))
                {
                    uniqueMossCodeCombinations[mossCodeComibnation]++;
                }
                else
                {
                    uniqueMossCodeCombinations.Add(mossCodeComibnation, 1);
                }
            }
            return uniqueMossCodeCombinations.Count;
        }
    }
}
