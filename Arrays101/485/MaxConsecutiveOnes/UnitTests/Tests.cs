using MaxConsecutiveOnes;
namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, int expected)
        {
            var solution = new Solution();
            var result = solution.FindMaxConsecutiveOnes(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolution(int[] input, int expected)
        {
            var solution = new OptimalSolution();
            var result = solution.FindMaxConsecutiveOnes(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new int[] { 1, 1, 0, 1, 1, 1 }, 3 };
            yield return new object[] { new int[] { 0, 0, 0, 0 }, 0 };
            yield return new object[] { new int[] { 1, 1, 1, 1 }, 4 };
            yield return new object[] { new int[] { 1, 0, 1, 1, 0, 1 }, 2 };
        }
    }
}