using DuplicateZeros;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, int[] expected)
        {
            var solution = new Solution();
            solution.DuplicateZeros(input);

            Assert.Equal(expected, input);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] input, int[] expected)
        {
            var solution = new LcApproachOne();
            solution.DuplicateZeros(input);

            Assert.Equal(expected, input);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 1, 0, 2, 3, 0, 4, 5, 0},
                new int[] { 1, 0, 0, 2, 3, 0, 0, 4 }
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3},
                new int[] { 1, 2, 3 }
            };
        }
    }
}