using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class JewelsAndStones
    {
        public static int Solution(string jewels,string stones)
        {
            int myJewels = 0;
            
            foreach(char stone in stones)
            {
                if (jewels.Contains(stone))
                {
                    myJewels++;
                }
            }
            
            return myJewels;
        }
    }
}
