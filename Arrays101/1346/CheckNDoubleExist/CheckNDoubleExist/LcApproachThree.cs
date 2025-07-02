using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CheckNDoubleExist
{
    public class LcApproachThree
    {
        public bool CheckIfExist(int[] arr)
        {
            // Step 1: Sort the array
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                // Step 2: Calculate the target (double of current number)
                int target = 2 * arr[i];
                // Step 3: Custom binary search for the target
                int index = customBinarySearch(arr, target);
                // If the target exists and is not the same index
                if (index >= 0 && index != i)
                {
                    return true;
                }
            }
            // No valid pair found
            return false;
        }

        //Implementation of binary search
        private int customBinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                // Avoid potential overflow
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Target not found
        }
    }
}
