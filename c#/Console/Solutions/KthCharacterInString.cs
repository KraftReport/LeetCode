using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class KthCharacterInString
    {
        public static char Solution(int k)
        {  
            var box = new StringBuilder();

            box.Append('a'); 

            while (box.ToString().Length < k)
            { 
                foreach(var character in box.ToString())
                {
                    if(character == 'z')
                    {
                        box.Append('a');
                    }
                    else
                    {
                        box.Append((char)(character + 1));
                    }
                }

            }
            return box.ToString()[k - 1];
        }
    }
}
