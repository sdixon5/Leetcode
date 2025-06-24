using RansomNoteSolutions;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySoltuion (string ransomNote, string magazine, bool expected)
        {
            var solution = new Solution();
            var result = solution.CanConstruct(ransomNote, magazine);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachOne (string ransomNote, string magazine, bool expected)
        {
            var solution = new OptimalSolutionApproachOne();
            var result = solution.CanConstruct(ransomNote, magazine);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachTwo(string ransomNote, string magazine, bool expected)
        {
            var solution = new OptimalSolutionApproachTwo();
            var result = solution.CanConstruct(ransomNote, magazine);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachThree(string ransomNote, string magazine, bool expected)
        {
            var solution = new OptimalSolutionApproachThree();
            var result = solution.CanConstruct(ransomNote, magazine);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                "a", "b", false
            };

            yield return new object[]
            {
                "aa", "ab", false
            };

            yield return new object[]
            {
                "aa", "aab", true
            };

            yield return new object[]
            {
                "aac", "aabbc", true
            };

            yield return new object[]
            {
                "leetcode", "arraylist", false
            };
        }
    }
}