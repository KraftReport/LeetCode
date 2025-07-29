using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class FlippingImage
    {
        public static int[][] Solution(int[][] image)
        {  
            for(int i = 0; i < image.Length; i++)
            {
                int left = 0;
                
                int right = image[i].Length-1;

                while (left <= right)
                {
                    if(left == right)
                    {
                        image[i][left] ^= 1;
                    }
                    else
                    {
                        int temp = image[i][left] ^ 1;
                        
                        image[i][left] = image[i][right] ^ 1;
                        
                        image[i][right] = temp;
                    }
                    left++;
                    right--;
                }
            }
            return image;
        }
    }
}
