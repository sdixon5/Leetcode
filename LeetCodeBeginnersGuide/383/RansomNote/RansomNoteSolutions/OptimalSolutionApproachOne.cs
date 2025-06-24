using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNoteSolutions
{
    public class OptimalSolutionApproachOne
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            for (int i = 0; i < ransomNote.Length; i++)
            {
                char r = ransomNote[i];

                int matchingIndex = magazine.IndexOf(r);

                if (matchingIndex == -1)
                {
                    return false;
                }

                magazine = magazine.Substring(0, matchingIndex) + magazine.Substring(matchingIndex + 1);
            }

            return true;
        }
    }
}
