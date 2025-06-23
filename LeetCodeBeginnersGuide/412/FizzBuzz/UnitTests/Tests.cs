using FizzBuzz;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int input, IList<string> expected)
        {
            var solution = new Solution();
            var result = solution.FizzBuzzOriginal(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolutionOptimized(int input, IList<string> expected)
        {
            var solution = new Solution();
            var result = solution.FizzBuzzOptimal(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolution(int input, IList<string> expected)
        {
            var solution = new OptimalSolution();
            var result = solution.FizzBuzz(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 3, new List<string> { "1", "2", "Fizz" } };
            yield return new object[] { 5, new List<string> { "1", "2", "Fizz", "4", "Buzz" } };
            yield return new object[] { 15, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } };
        }
    }
}