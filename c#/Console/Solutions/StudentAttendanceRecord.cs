using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class StudentAttendanceRecord
    {
        public static bool Solution(string s)
        {
            int absentCount = 0;
            
            int concetutiveLateCount = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    absentCount++;
                }

                if (s[i] == 'L')
                {
                    concetutiveLateCount++;
                }
                else
                {
                    concetutiveLateCount = 0;
                }

                if(absentCount>1 || concetutiveLateCount > 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
