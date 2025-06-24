using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDistantIndicies
{
    public class EditorialOneTraversalSolution
    {
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            List<int> res = new List<int>();
            int r = 0;  // unjudged minimum index
            int n = nums.Length;
            for (int j = 0; j < n; j++)
            {
                if (nums[j] == key)
                {
                    int l = Math.Max(r, j - k);
                    r = Math.Min(n - 1, j + k) + 1;
                    for (int i = l; i < r; i++)
                    {
                        res.Add(i);
                    }
                }
            }
            return res;
        }
    }
}
