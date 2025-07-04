﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    public class LcApproachTwo
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Make a copy of the first m elements of nums1.
            int[] nums1Copy = new int[m];
            Array.Copy(nums1, 0, nums1Copy, 0, m);
            // Read pointers for nums1Copy and nums2 respectively.
            int p1 = 0;
            int p2 = 0;
            // Compare elements from nums1Copy and nums2 and write the smallest to
            // nums1.
            for (int p = 0; p < m + n; p++)
            {
                // We also need to ensure that p1 and p2 aren't over the boundaries
                // of their respective arrays.
                if (p2 >= n || (p1 < m && nums1Copy[p1] < nums2[p2]))
                {
                    nums1[p] = nums1Copy[p1++];
                }
                else
                {
                    nums1[p] = nums2[p2++];
                }
            }
        }
    }
}
