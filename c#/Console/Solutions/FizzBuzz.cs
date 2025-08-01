﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class FizzBuzz
    {
        public static IList<string> Solution(int n)
        {
            var result = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                if(i%3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }else if(i%3 == 0)
                {
                    result.Add("Fizz");
                }else if(i% 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}
