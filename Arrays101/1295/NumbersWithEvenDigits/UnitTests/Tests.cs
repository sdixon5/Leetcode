using FindEvenNumberOfDigits;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, int expected)
        {
            var solution = new Solution();
            var result = solution.FindNumbers(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachOne(int[] input, int expected)
        {
            var solution = new OptimalSolutionApproachOne();
            var result = solution.FindNumbers(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachTwo(int[] input, int expected)
        {
            var solution = new OptimalSolutionApproachTwo();
            var result = solution.FindNumbers(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachThree(int[] input, int expected)
        {
            var solution = new OptimalSolutionApproachThree();
            var result = solution.FindNumbers(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachFour(int[] input, int expected)
        {
            var solution = new OptimalSolutionApproachFour();
            var result = solution.FindNumbers(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 12, 345, 2, 6, 7896 },
                2
            };

            yield return new object[]
            {
                new int[] { 555, 901, 482, 1771 },
                1
            };
        }
    }
}