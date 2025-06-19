using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestSubstringNoRepeats.Tests
{
    public class SubstringTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void SubstringNoRepeats(string testString, int expected)
        {
            Solution solution = new Solution();

            Assert.Equal(expected, solution.LengthOfLongestSubstring(testString));
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void OptimalSolution(string testString, int expected)
        {
            OptimalSolution solution = new OptimalSolution();

            Assert.Equal(expected, solution.LengthOfLongestSubstring(testString));
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { "abcabcbb", 3};
            yield return new object[] { "bbbbb", 1};
            yield return new object[] { "pwwkew", 3};
            yield return new object[] { " ", 1};
            yield return new object[] { "au", 2};
            yield return new object[] { "aab", 2 };
        }
    }
}
