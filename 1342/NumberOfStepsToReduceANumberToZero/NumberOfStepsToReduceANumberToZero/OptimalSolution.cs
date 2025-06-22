using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStepsToReduceANumberToZero
{
    public class OptimalSolution
    {
        public int NumberOfSteps(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                //Before we used num % 2
                if ((num & 1) == 0)
                { //num: xxxxxx0 & bitmask: 0000001
                  //Before we used num /= 2
                    num >>= 1; //num = num >> 1;
                }
                else
                {
                    num--;
                }

                steps++;
            }

            return steps;
        }

        //Time Complexity = O(logn)
        //Space Complexity = O(1)
    }
}
