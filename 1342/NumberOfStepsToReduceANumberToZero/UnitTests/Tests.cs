using NumberOfStepsToReduceANumberToZero;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMyMethod(int input, int expected)
        {
            var solution = new Solution();
            var result = solution.NumberOfSteps(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalMethod(int input, int expected)
        {
            var solution = new OptimalSolution();
            var result = solution.NumberOfSteps(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 14, 6 };
            yield return new object[] { 8, 4 };
            yield return new object[] { 123, 12 };
            yield return new object[] { 0, 0 };
            yield return new object[] { 1, 1 };
            yield return new object[] { 6, 4 };
        }
    }
}