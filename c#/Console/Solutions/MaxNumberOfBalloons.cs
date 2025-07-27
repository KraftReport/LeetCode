using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class MaxNumberOfBalloons
    {
        public static int Solution(string text)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>
            {
                { 'b', 0 },
                { 'a', 0 },
                { 'l', 0 },
                { 'o', 0 },
                { 'n', 0 }
            };

            int result = 0;

            foreach (char character in text)
            {
                if(dictionary.TryGetValue(character, out int value)) dictionary[character] = ++value;
                
                if (dictionary['b'] > 0 &&
                    dictionary['a'] > 0 &&
                    dictionary['l'] > 1 &&
                    dictionary['o'] > 1 &&
                    dictionary['n'] > 0)
                {
                    result++;
                    dictionary['b']--;
                    dictionary['a']--;
                    dictionary['l'] = dictionary['l']-2;
                    dictionary['o'] = dictionary['o']-2;
                    dictionary['n']--;
                } 
            }

            return result;
        }
    }
}
