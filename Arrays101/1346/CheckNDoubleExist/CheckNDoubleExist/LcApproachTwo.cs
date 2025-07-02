using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNDoubleExist
{
    public class LcApproachTwo
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                // Check if 2 * num or num / 2 exists in the set
                if (
                    seen.Contains(2 * num) ||
                    (num % 2 == 0 && seen.Contains(num / 2))
                )
                {
                    return true;
                }
                // Add the current number to the set
                seen.Add(num);
            }
            // No valid pair found
            return false;
        }
    }
}
