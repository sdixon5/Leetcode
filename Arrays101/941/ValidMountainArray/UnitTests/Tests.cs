using ValidMountainArray;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] input, bool expected)
        {
            var solution = new Solution();
            var result = solution.ValidMountainArray(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] input, bool expected)
        {
            var solution = new LcApproachOne();
            var result = solution.ValidMountainArray(input);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] {2,1},
                false
            };

            yield return new object[]
            {
                new int[] {3,5,5},
                false
            };

            yield return new object[]
            {
                new int[] {0,3,2,1},
                true
            };

            yield return new object[] 
            {
                new int[] { 2, 0, 2 },
                false
            };
        }
    }
}