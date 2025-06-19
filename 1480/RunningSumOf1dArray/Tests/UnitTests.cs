using RunningSumOf1dArray;

namespace Tests
{
    public class UnitTests
    {
        [Theory]
        [MemberData(nameof(ArrayTestData))]
        public void TestRunningSumMyVersion(int[] input, int[] expected)
        {
            var solution = new Solution();
            var result = solution.RunningSum(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(ArrayTestData))]
        public void TestRunningSumOptimalSolution(int[] input, int[] expected)
        {
            var solution = new OptimalSolution();
            var result = solution.RunningSum(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> ArrayTestData()
        {
            yield return new object[]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 3, 6, 10 }
            };

            yield return new object[]
            {
                new int[] {1, 1, 1, 1, 1 },
                new int[] { 1, 2, 3, 4, 5 }
            };

            yield return new object[]
            {
                new int[] { 3, 1, 2, 10, 1},
                new int[] { 3, 4, 6, 16, 17 }
            };
        }
    }
}