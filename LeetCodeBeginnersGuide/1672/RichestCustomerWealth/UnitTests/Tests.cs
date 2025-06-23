namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void MaximumWealthMySolution(int[][] input, int expected)
        {
            var solution = new RichestCustomerWealth.Solution();
            var result = solution.MaximumWealth(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void MaximumWealthOptimalSolution(int[][] input, int expected)
        {
            var solution = new RichestCustomerWealth.OptimalSolution();
            var result = solution.MaximumWealth(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 3, 2, 1 }
                },
                6
            };

            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 1, 5 },
                    new int[] { 7, 3 },
                    new int[] { 3, 5 }
                },
                10
            };

            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 2, 8, 7 },
                    new int[] { 7, 1, 3 },
                    new int[] { 1, 9, 5 }
                },
                17
            };
        }
    }
}