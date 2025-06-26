using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfSortedArray
{
    public class LcApproachOne
    {
        public int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = nums[i] * nums[i];
            }

            Array.Sort(result);
            return result;
        }
    }
}
