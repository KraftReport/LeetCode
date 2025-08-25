using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class GroupThePeopleGivenTheGroupTheyBelongTo
    {
        public static IList<IList<int>> Solution(int[] groupSizes)
        {
            Dictionary<int,List<int>> dataMap = new Dictionary<int,List<int>>();

            IList<IList<int>> result = new List<IList<int>>();

            for(int i = 0; i < groupSizes.Length; i++)
            {
                if (!dataMap.ContainsKey(groupSizes[i])) dataMap[groupSizes[i]] = new List<int>();

                dataMap[groupSizes[i]].Add(i);
            }

            foreach(KeyValuePair<int,List<int>> data in dataMap.OrderBy(x=>x.Key))
            {
                List<int> list = new List<int>();
                foreach(int i in data.Value)
                { 
                    list.Add(i);
                    if(list.Count == data.Key)
                    {
                        result.Add(list);
                        list = new List<int>();
                    }
                }
            }

            return result; 
        }
    }
}
