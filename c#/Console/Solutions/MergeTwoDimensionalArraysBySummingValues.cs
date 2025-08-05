using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class MergeTwoDimensionalArraysBySummingValues
    {
        public static int[][] Solution(int[][] nums1, int[][] nums2)
        {
            Dictionary<int ,int> dictionary = new Dictionary<int, int>();
            int firstPointer = 0;
            int secondPointer = 0;

            while (firstPointer < nums1.Length && secondPointer < nums2.Length)
            {
                int[] firstPair = nums1[firstPointer];
                int[] secondPair = nums2[secondPointer];

                if (firstPair[0] == secondPair[0])
                {
                    dictionary[firstPair[0]] = firstPair[1] + secondPair[1];
                    firstPointer++;
                    secondPointer++;
                }
                else if (firstPair[0] < secondPair[0])
                {
                    dictionary[firstPair[0]] = firstPair[1];
                    firstPointer++;
                }
                else // secondPair[0] < firstPair[0]
                {
                    dictionary[secondPair[0]] = secondPair[1];
                    secondPointer++;
                }
            }

            // Add remaining from nums1
            while (firstPointer < nums1.Length)
            {
                int[] pair = nums1[firstPointer++];
                dictionary[pair[0]] = pair[1];
            }

            // Add remaining from nums2
            while (secondPointer < nums2.Length)
            {
                int[] pair = nums2[secondPointer++];
                dictionary[pair[0]] = pair[1];
            }

            var sortedKeys = dictionary.Keys.OrderBy(k => k).ToList();
            int[][] result = new int[sortedKeys.Count][];

            for (int i = 0; i < sortedKeys.Count; i++)
            {
                int key = sortedKeys[i];
                result[i] = new int[] { key, dictionary[key] };
            }


            return result;
        }
    }
}
