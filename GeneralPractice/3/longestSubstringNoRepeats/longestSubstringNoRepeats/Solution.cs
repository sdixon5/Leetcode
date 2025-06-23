using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestSubstringNoRepeats
{
    public class Solution
    {

        public int LengthOfLongestSubstring(string s)
        {
            string longest = "";
            string current = "";
            int start = 0;

            for (int i = start; i < s.Length; i++)
            {
                if (i == start)
                {
                    current += s[i];
                }
                else if (!(current.Contains(s[i])))
                {
                    current += s[i];
                }
                else
                {
                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }
                    start++;
                    i = start - 1;
                    current = "";
                    continue;
                }
            }

            if (longest == "" || current.Length > longest.Length)
            {
                longest = current;
            }

            return longest.Length;
        }
    }
}
