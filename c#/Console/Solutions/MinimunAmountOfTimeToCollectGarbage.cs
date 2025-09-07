using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class MinimunAmountOfTimeToCollectGarbage
    {
        public static int Solution(string[] garbage, int[] travel)
        {
            int metalGarbageCollectionTime = 0;
            int metalGarbageTravelTime = 0;
            int paperGarbageCollectionTime = 0;
            int paperGarbageTravelTime = 0;
            int glassGarbageCollectionTime = 0;
            int glassGarbageTravelTime = 0;
            int travelTime = 0;
            for (int i = 0; i < garbage.Length; i++)
            { 
                if(i > 0) travelTime += travel[i - 1];
                if (garbage[i].Contains('M'))
                {
                    metalGarbageCollectionTime += Regex.Matches(garbage[i], "M").Count;
                    metalGarbageTravelTime = travelTime;
                }
                if (garbage[i].Contains('P'))
                {
                    paperGarbageCollectionTime += Regex.Matches(garbage[i], "P").Count;
                    paperGarbageTravelTime = travelTime;
                }
                if (garbage[i].Contains('G'))
                {
                    glassGarbageCollectionTime += Regex.Matches(garbage[i], "G").Count;
                    glassGarbageTravelTime = travelTime;
                }                
            }
            return metalGarbageCollectionTime + metalGarbageTravelTime + paperGarbageCollectionTime + paperGarbageTravelTime + glassGarbageCollectionTime + glassGarbageTravelTime;
        }
    }
}
