using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class LicenceKeyFormatting
    {
        public static string Solution(string s,int k)
        {
            string words = s.Replace("-","").ToUpper(); 
            
            StringBuilder formattedLicenceKey = new StringBuilder();
            
            int currentSectorCount = 0;

            for (int i = words.Length-1; i >= 0; i--)
            {
                if (currentSectorCount == k)
                {
                    formattedLicenceKey.Insert(0, '-');
                    currentSectorCount = 0;
                }

                formattedLicenceKey.Insert(0, words[i]);
                currentSectorCount++;
            }
            return formattedLicenceKey.ToString();
        }
    }
}
