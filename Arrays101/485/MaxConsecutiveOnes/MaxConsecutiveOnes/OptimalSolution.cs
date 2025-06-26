using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxConsecutiveOnes
{
    public class OptimalSolution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    // Increment the count of 1's by one.
                    count += 1;
                }
                else
                {
                    // Find the maximum till now.
                    maxCount = Math.Max(maxCount, count);
                    // Reset count of 1.
                    count = 0;
                }
            }
            return Math.Max(maxCount, count);
        }
    }
}
