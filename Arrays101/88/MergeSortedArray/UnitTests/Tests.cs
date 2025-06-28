using MergeSortedArray;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(int[] mArray, int m, int[] nArray, int n, int[] expected)
        {
            var solution = new Solution();
            solution.Merge(mArray, m, nArray, n);

            Assert.Equal(expected, mArray);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachOne(int[] mArray, int m, int[] nArray, int n, int[] expected)
        {
            var solution = new LcApproachOne();
            solution.Merge(mArray, m, nArray, n);

            Assert.Equal(expected, mArray);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachTwo(int[] mArray, int m, int[] nArray, int n, int[] expected)
        {
            var solution = new LcApproachTwo();
            solution.Merge(mArray, m, nArray, n);

            Assert.Equal(expected, mArray);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestLcApproachThree(int[] mArray, int m, int[] nArray, int n, int[] expected)
        {
            var solution = new LcApproachThree();
            solution.Merge(mArray, m, nArray, n);

            Assert.Equal(expected, mArray);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int [] {1, 2, 3, 0, 0, 0},
                3,
                new int [] {2, 5, 6},
                3,
                new int [] {1, 2, 2, 3, 5, 6}
            };

            yield return new object[]
            {
                new int [] {1, 2, 3, 0, 0, 0},
                3,
                new int [] {4, 5, 6},
                3,
                new int [] {1, 2, 3, 4, 5, 6}
            };

            yield return new object[]
            {
                new int [] {0, 0, 0, 0, 0, 0},
                0,
                new int [] {1, 2, 3},
                3,
                new int [] {1, 2, 3, 0, 0, 0}
            };

            yield return new object[]
            {
                new int [] {1, 2, 3, 4, 5, 6},
                6,
                new int [] {},
                0,
                new int [] {1, 2, 3, 4, 5, 6}
            };

            yield return new object[]
            {
                new int [] {0, 0, 0, 0, 0, 0},
                0,
                new int [] {},
                0,
                new int [] {0, 0, 0, 0, 0, 0}
            };

            yield return new object[]
            {
                new int [] {1, 0, 0, 0, 0, 0},
                1,
                new int [] {2, 3, 4, 5, 6},
                5,
                new int [] {1, 2, 3, 4, 5, 6}
            };

            yield return new object[]
            {
                new int [] {4, 5, 6, 0, 0, 0},
                3,
                new int [] {1, 2, 3},
                3,
                new int [] {1, 2, 3, 4, 5, 6}
            };

            yield return new object[]
            {
                new int[] {-1,0,0,3,3,3,0,0,0 },
                6,
                new int[] {1,2,2 },
                3,
                new int[] {-1,0,0,1,2,2,3,3,3}
            };
        }
    }
}