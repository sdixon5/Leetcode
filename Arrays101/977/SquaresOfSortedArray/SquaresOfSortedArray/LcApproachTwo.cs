using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfSortedArray
{
    public class LcApproachTwo
    {
        public int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int left = 0;
            int right = n - 1;

            for (int i = n - 1; i >= 0; i--)
            {
                int square;

                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    square = nums[right];
                    right--;
                }
                else
                {
                    square = nums[left];
                    left++;
                }

                result[i] = square * square;
            }

            return result;
        }
    }
}
