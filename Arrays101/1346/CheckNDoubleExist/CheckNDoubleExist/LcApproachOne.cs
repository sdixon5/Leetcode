using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNDoubleExist
{
    public class LcApproachOne
    {
        public bool CheckIfExist(int[] arr)
        {
            // Step 1: Iterate through all pairs of indices
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    // Step 2: Check the conditions
                    if (i != j && arr[i] == 2 * arr[j])
                    {
                        return true;
                    }
                }
            }
            // No valid pair found
            return false;
        }
    }
}
