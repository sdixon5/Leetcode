using CheckNDoubleExist;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, bool expected)
        {
            var solution = new Solution();
            var result = solution.CheckIfExist(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] input, bool expected)
        {
            var solution = new LcApproachOne();
            var result = solution.CheckIfExist(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachTwo(int[] input, bool expected)
        {
            var solution = new LcApproachTwo();
            var result = solution.CheckIfExist(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachThree(int[] input, bool expected)
        {
            var solution = new LcApproachThree();
            var result = solution.CheckIfExist(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachFour(int[] input, bool expected)
        {
            var solution = new LcApproachFour();
            var result = solution.CheckIfExist(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 10, 2, 5, 3 },
                true
            };

            yield return new object[]
            {
                new int[] { 3, 1, 7, 11 },
                false
            };

            yield return new object[]
            {
                new int[] { 0, 0 },
                true
            };
        }
    }
}