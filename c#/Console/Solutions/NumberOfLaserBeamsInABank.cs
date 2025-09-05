using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class NumberOfLaserBeamsInABank
    {
        public static int Solution(string[] bank)
        {
            int laserBeams = 0; 
            for (int i = 0; i < bank.Length; i++)
            {
                char[] floor = bank[i].ToCharArray();
                foreach(char securityDevice in floor)
                {
                    bool isSecurityDevicePresentBetweenFloors = false;
                    if (securityDevice == '1')
                    { 
                        for (int j = i + 1; j < bank.Length; j++)
                        {
                            if(!isSecurityDevicePresentBetweenFloors)
                            {
                                char[] upperFloor = bank[j].ToCharArray();
                                foreach (char upperFloorSecurityDevice in upperFloor)
                                {
                                    if (upperFloorSecurityDevice == '1')
                                    {
                                        laserBeams++; 
                                        isSecurityDevicePresentBetweenFloors = true;
                                    }
                                }
                            } 
                        }
                    }
                }
            }
            return laserBeams;
        }
    }
}
