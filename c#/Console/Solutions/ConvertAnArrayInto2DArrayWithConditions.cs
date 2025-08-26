using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class ConvertAnArrayInto2DArrayWithConditions
    {
        public static IList<IList<int>> Solution(int[] nums)
        {
            List<int> list = new List<int>(nums);
            IList<IList<int>> result = new List<IList<int>>();

            while (list.Count != 0)
            {
                List<int> subList = new List<int>();
                HashSet<int> set = new HashSet<int>(); 
                int skip = 0;
                while (skip < list.Count)
                {
                    if (!set.Contains(list[skip]))
                    {
                        subList.Add(list[skip]);
                        set.Add(list[skip]);
                        list.RemoveAt(skip);
                    }
                    else
                    {
                        skip++;
                    }
                }
                result.Add(subList);
            } 
            return result;
        }
    }
}
