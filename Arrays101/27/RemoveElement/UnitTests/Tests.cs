using RemoveElement;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] nums, int val, int expected, int[] finalNums)
        {
            var solution = new Solution();
            var result = solution.RemoveElement(nums, val);

            Assert.Equal(expected, result);
            Assert.Equal(finalNums, nums);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] nums, int val, int expected, int[] finalNums)
        {
            var solution = new LcApproachOne();
            var result = solution.RemoveElement(nums, val);

            Assert.Equal(expected, result);
            //Assert.Equal(finalNums, nums);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachTwo(int[] nums, int val, int expected, int[] finalNums)
        {
            var solution = new LcApproachTwo();
            var result = solution.RemoveElement(nums, val);

            Assert.Equal(expected, result);
            //Assert.Equal(finalNums, nums);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { 3, 2, 2, 3 },
                3,
                2,
                new int [] { 2, 2, 0, 0 }
            };

            yield return new object[]
            {
                new int[] { 0, 1, 2, 2, 3, 0, 4, 2 },
                2,
                5,
                new int [] { 0, 1, 3, 0, 4, 0, 0, 0 }
            };
        }
    }
}