using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class LuckyInteger
    {
        public static int Solution(int[] arr)
        {
            var hashMap = new Dictionary<int, int>();

            var largest = 0;

            for(int i= 0; i< arr.Length; i++)
            {
                if (hashMap.ContainsKey(arr[i]))
                {
                    hashMap[arr[i]]++;
                }
                else
                {
                    hashMap[arr[i]] = 1;
                }
            }

            for(int i = hashMap.Count-1; i >=0; i--)
            {
                if(hashMap.ElementAt(i).Key == hashMap.ElementAt(i).Value)
                {
                    if(hashMap.ElementAt(i).Key > largest)
                    {
                        largest = hashMap.ElementAt(i).Key;
                    }
                }
            }

            if (largest != 0) return largest;

            return -1;
        }
    }
}
