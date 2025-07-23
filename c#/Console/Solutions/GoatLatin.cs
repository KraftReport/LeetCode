using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class GoatLatin
    {
        public static string Solution(string sentence)
        {
            string vowels = "aeiouAEIOU";
            
            string[] words = sentence.Split(' ');
            
            string result = string.Empty;

            string suffixA = "a";

            string suffixMa = "ma";

            for (int i = 0; i < words.Length; i++)
            {
                string trnasformedWord = string.Empty;

                if (vowels.Contains(words[i][0]))
                {
                    trnasformedWord = words[i] + suffixMa + suffixA;
                }
                else
                {
                    trnasformedWord = words[i].Substring(1) + words[i][0] + suffixMa + suffixA;
                }

                suffixA = suffixA + "a";
                
                result += trnasformedWord;
                
                if (i < words.Length - 1)
                {
                    result += " ";
                }
            }

            return result;
        }
    }
}
