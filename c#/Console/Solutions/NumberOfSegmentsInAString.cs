using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class NumberOfSegmentsInAString
    {
        public static int Solution(string s)
        {
            var segments = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return segments.Length;
        }
    }
}
