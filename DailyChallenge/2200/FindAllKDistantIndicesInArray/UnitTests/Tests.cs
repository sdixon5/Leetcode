using KDistantIndicies;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] nums, int key, int k, IList<int> expected)
        {
            var solution = new Solution();
            var results = solution.FindKDistantIndices(nums, key, k);

            Assert.Equal(expected, results);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestEditorialEnumerationSolution(int[] nums, int key, int k, IList<int> expected)
        {
            var solution = new EditorialEnumerationSolution();
            var results = solution.FindKDistantIndices(nums, key, k);

            Assert.Equal(expected, results);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestEditorialOneTraversalSolution(int[] nums, int key, int k, IList<int> expected)
        {
            var solution = new EditorialOneTraversalSolution();
            var results = solution.FindKDistantIndices(nums, key, k);

            Assert.Equal(expected, results);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] {3, 4, 9, 1, 3, 9, 5},
                9,
                1,
                new List<int> { 1, 2, 3, 4, 5, 6 }
            };

            yield return new object[]
            {
                new int[] {2,2,2,2,2},
                2,
                2,
                new List<int> { 0, 1, 2, 3, 4 }
            };
        }
    }
}