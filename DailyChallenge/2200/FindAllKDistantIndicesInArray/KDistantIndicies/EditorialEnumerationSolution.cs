﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDistantIndicies
{
    public class EditorialEnumerationSolution
    {
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            List<int> res = new List<int>();
            int n = nums.Length;
            // traverse number pairs
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (nums[j] == key && Math.Abs(i - j) <= k)
                    {
                        res.Add(i);
                        break;  // early termination to prevent duplicate addition
                    }
                }
            }
            return res;
        }
    }
}
