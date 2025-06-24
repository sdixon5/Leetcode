using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNoteSolutions
{
    public class OptimalSolutionApproachThree
    {
        /* This solution is best according to Google Gemini because it uses modern dictionary instead of hashtable which is a huge performance and type safety improvement over the hashtable from the video soltuion.
        * This is also a better approach than mine because it uses only one dictionary.
        * It more closely follows the requirments of "using up" the letters.
        * It uses less iterations.
        */

        public bool CanConstruct(string ransomNote, string magazine)
        {
            // Use Dictionary for character counts - modern and efficient
            Dictionary<char, int> magazineLetters = new Dictionary<char, int>();

            // Count each character in magazine
            foreach (char c in magazine)
            {
                // TryGetValue is excellent for checking existence and getting value in one go
                if (magazineLetters.TryGetValue(c, out int currentCount))
                {
                    magazineLetters[c] = currentCount + 1;
                }
                else
                {
                    magazineLetters.Add(c, 1);
                }
            }

            // Check if ransomNote can be constructed
            foreach (char r in ransomNote)
            {
                // Check if character exists and if its count is greater than 0
                if (magazineLetters.TryGetValue(r, out int currentCount) && currentCount > 0)
                {
                    magazineLetters[r] = currentCount - 1; // Decrement the count (use the character)
                }
                else
                {
                    return false; // Character not available or count is zero
                }
            }

            return true;
        }
    }
}
