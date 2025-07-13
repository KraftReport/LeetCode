using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class AddStrings
    {
        public static string Solution(string num1,string num2)
        { 
            return BigInteger.Parse(num1) + BigInteger.Parse(num2) + ""; 
        }
    }
}
