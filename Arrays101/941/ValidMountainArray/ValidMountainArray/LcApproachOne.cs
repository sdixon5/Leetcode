using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidMountainArray
{
    public class LcApproachOne
    {
        public bool ValidMountainArray(int[] arr)
        {
            int N = arr.Length;
            int i = 0;

            // walk up
            while (i + 1 < N && arr[i] < arr[i + 1])
                i++;

            // peak can't be first or last
            if (i == 0 || i == N - 1)
                return false;

            // walk down
            while (i + 1 < N && arr[i] > arr[i + 1])
                i++;

            return i == N - 1;
        }
    }
}
