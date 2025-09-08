using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class CountTripletsThatCanFormTwoArraysOfEqualXOR
    {
        public static int Solution(int[] arr)
        { 
            int result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int a = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    a ^= arr[j-1];
                    int b = 0;
                    for (int k = j; k < arr.Length; k++)
                    {
                        b ^= arr[k];
                        if (a == b) result++;
                    }
                }
            } 
            return result;
        }
    }
}
