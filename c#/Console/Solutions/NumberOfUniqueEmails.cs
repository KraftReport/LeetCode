using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class NumberOfUniqueEmails
    {
        public static int Solution(string[] emails)
        {
            HashSet<string> uniqueEmails = new HashSet<string>();

            foreach(string email in emails)
            {
                Match pattern = Regex.Match(email,@"^([^@]+)@(.+)$");

                string local = pattern.Groups[1].Value;
                
                string domain = pattern.Groups[2].Value;

                local = Regex.Replace(local, @"\+.*", "");
                
                local = Regex.Replace(local, @"\.", "");

                string normalizedEmail = $"{local}@{domain}";

                uniqueEmails.Add(normalizedEmail);
            }

            return uniqueEmails.Count;
        }
    }
}
