using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class MinNumbersOfOperationsToMoveAllBallsIntoEachBox
    {
        public static int[] Solution(string boxes)
        {
            char[] balls = boxes.ToCharArray();
            int[] result = new int[boxes.Length]; 
            for(int i = 0; i < balls.Length; i++)
            {
                int currentBoxIndex = i;
                int otherBoxIndex = 0;
                while (otherBoxIndex < balls.Length)
                {
                    if (otherBoxIndex != currentBoxIndex)
                        if (balls[otherBoxIndex] != '0')
                            result[currentBoxIndex] += Math.Abs(currentBoxIndex - otherBoxIndex);
 
                    otherBoxIndex++;
                } 
            }
            return result;
        }
    }
}
