using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceGreatestOnRight
{
    public class LcApproachOne
    {
        /*
         * No official solution
         * Solution provided by other user answers
         */
        public int[] ReplaceElements(int[] arr)
        {
            int max = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int newMax = Math.Max(max, arr[i]);
                arr[i] = max;
                max = newMax;
            }

            return arr;
        }
    }
}
