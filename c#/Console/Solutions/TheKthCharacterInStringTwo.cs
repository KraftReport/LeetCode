using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class TheKthCharacterInStringTwo
    {
        public static char Solution(long k, int[] operations)
        { 
            var result = "a";

            for(int i =0; i < operations.Length; i++)
            {
                int secondBuilder = 0;

                var thirdBuilder = new StringBuilder();

                for(int j= 0; j< result.Length; j++)
                {
                    if (result[j]== 'z')
                    {
                        secondBuilder = 97 + (operations[i] -1);
                    }
                    else
                    {
                        secondBuilder = (char)result[j] + operations[i];
                    }
                    thirdBuilder.Append((char)secondBuilder);
                }
                System.Console.WriteLine(thirdBuilder.ToString());
                result = result + thirdBuilder.ToString();
            }

            var index = Convert.ToInt32(k) - 1;

            System.Console.WriteLine(result);

            return result[index];
        }
    }
}
