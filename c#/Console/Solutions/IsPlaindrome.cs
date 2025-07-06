using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class IsPlaindrome
    {
        public static bool Solution(int x)
        {
            var stringValue = x.ToString();

            for (var i = 0; i <= (stringValue.Length / 2); i++)
            {
                if (stringValue[i] != stringValue[stringValue.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
