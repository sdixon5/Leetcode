using ReplaceGreatestOnRight;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, int[] expected)
        {
            var solution = new Solution();
            var result = solution.ReplaceElements(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] input, int[] expected)
        {
            var solution = new LcApproachOne();
            var result = solution.ReplaceElements(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 17, 18, 5, 4, 6, 1 },
                new int[] { 18, 6, 6, 6, 1, -1 }
            };

            yield return new object[]
            {
                new int[] { 400 },
                new int[] { -1 }
            };
        }
    }
}