using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNDoubleExist
{
    public class LcApproachFour
    {
        public bool CheckIfExist(int[] arr)
        {
            var map = new Dictionary<int, int>();

            // Count occurrences of each number
            foreach (int num in arr)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            // Check for double
            foreach (int num in arr)
            {
                if (num != 0 && map.ContainsKey(2 * num))
                {
                    return true;
                }
                // Handle zero case (ensure there are at least two zeros)
                if (num == 0 && map[num] > 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
