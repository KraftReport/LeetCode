using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class MaximunNumberOfCoinYouCanGet
    {
        public static int Solution(int[] piles)
        {
            int result = 0; 
            List<int> ascSortedList = piles.OrderBy(x =>x).ToList(); 
            while(ascSortedList.Count > 0)
            {
                ascSortedList.RemoveAt(ascSortedList.Count - 1);
                result += ascSortedList[ascSortedList.Count - 1];
                ascSortedList.RemoveAt(ascSortedList.Count - 1);
                ascSortedList.RemoveAt(0);
            }
            return result;
        }
    }
}
