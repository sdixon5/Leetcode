﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    public class LcApproachThree
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Set p1 and p2 to point to the end of their respective arrays.
            int p1 = m - 1;
            int p2 = n - 1;
            // And move p backward through the array, each time writing
            // the largest value pointed at by p1 or p2.
            for (int p = m + n - 1; p >= 0; p--)
            {
                if (p2 < 0)
                {
                    break;
                }

                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1--];
                }
                else
                {
                    nums1[p] = nums2[p2--];
                }
            }
        }
    }
}
