using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class DefangingIpAddress
    {
        public static string Solution(string address)
        {
            StringBuilder defangedIpAddress = new StringBuilder();

            foreach(char character in address)
            {
                if(character == '.')
                {
                    defangedIpAddress.Append("[.]");
                }
                else
                {
                    defangedIpAddress.Append(character);
                }
            }

            return defangedIpAddress.ToString();
        }
    }
}
