using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class RingAndRods
    {
        public static int Solution(string rings)
        {
            int threeRingsRod = 0;

            Dictionary<char,HashSet<char>> rodAndUniqueRings = new Dictionary<char, HashSet<char>>();

            for(int i = 0; i < rings.Length; i = i + 2)
            {
                char color = rings[i];
               
                char rod = rings[i + 1];
                
                if (!rodAndUniqueRings.ContainsKey(rod))
                { 
                    rodAndUniqueRings.Add(rod, [color]);
                }
                else
                {
                    rodAndUniqueRings[rod].Add(color);
                }
            }

            foreach(char rod in rodAndUniqueRings.Keys)
            {
                if (rodAndUniqueRings[rod].Count== 3)
                {
                    threeRingsRod++;
                }
            }

            return threeRingsRod;
        }
    }
}
