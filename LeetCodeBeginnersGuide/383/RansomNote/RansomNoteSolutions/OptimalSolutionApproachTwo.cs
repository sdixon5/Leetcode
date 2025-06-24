using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNoteSolutions
{
    public class OptimalSolutionApproachTwo
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            // Use Hashtable for character counts
            var magazineLetters = new System.Collections.Hashtable();

            // Count each character in magazine
            for (int i = 0; i < magazine.Length; i++)
            {
                char c = magazine[i];
                int currentCount = magazineLetters.ContainsKey(c) ? (int)magazineLetters[c] : 0;
                magazineLetters[c] = currentCount + 1;
            }

            // Check if ransomNote can be constructed
            for (int i = 0; i < ransomNote.Length; i++)
            {
                char r = ransomNote[i];
                int currentCount = magazineLetters.ContainsKey(r) ? (int)magazineLetters[r] : 0;

                if (currentCount == 0)
                {
                    return false;
                }

                magazineLetters[r] = currentCount - 1;
            }

            return true;
        }
    }
}
