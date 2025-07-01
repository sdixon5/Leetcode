using RemoveDuplicatedSortedArray;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, int expected)
        {
            var solution = new Solution();
            var result = solution.RemoveDuplicates(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] input, int expected)
        {
            var solution = new LcApproachOne();
            var result = solution.RemoveDuplicates(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 1, 1, 2 },
                2
            };

            yield return new object[]
            {
                new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
                5
            };
        }
    }
}