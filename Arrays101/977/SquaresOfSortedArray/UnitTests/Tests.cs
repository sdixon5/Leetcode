using SquaresOfSortedArray;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, int[] expected)
        {
            var solution = new Solution();
            var result = solution.SortedSquares(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] input, int[] expected)
        {
            var solution = new LcApproachOne();
            var result = solution.SortedSquares(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachTwo(int[] input, int[] expected)
        {
            var solution = new LcApproachTwo();
            var result = solution.SortedSquares(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { -4, -1, 0, 3,10 },
                new int[] { 0, 1, 9, 16, 100 }
            };

            yield return new object[]
            {
                new int[] { -7, -3, 2, 3, 11 },
                new int[] { 4, 9, 9, 49, 121 }
            };
        }
    }
}