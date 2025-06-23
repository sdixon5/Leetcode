using MiddleOfTheLinkedList;

namespace UnitTests
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMySolution(ListNode input, ListNode expected)
        {
            var solution = new Solution();
            var result = solution.MiddleNode(input);

            Assert.True(AreEqual(expected, result));
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachOne(ListNode input, ListNode expected)
        {
            var solution = new OptimalSolutionApproachOne();
            var result = solution.MiddleNode(input);

            Assert.True(AreEqual(expected, result));
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestOptimalSolutionApproachTwo(ListNode input, ListNode expected)
        {
            var solution = new OptimalSolutionApproachTwo();
            var result = solution.MiddleNode(input);

            Assert.True(AreEqual(expected, result));
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { BuildList([1, 2, 3, 4, 5]), BuildList([3, 4, 5]) };
            yield return new object[] { BuildList([1, 2, 3, 4, 5, 6]), BuildList([4, 5, 6]) };
            yield return new object[] { BuildList([3, 1, 2, 7, 7]), BuildList([2, 7, 7]) };
        }

        private static bool AreEqual(ListNode a, ListNode b)
        {
            while (a != null && b != null)
            {
                if (a.val != b.val)
                    return false;
                a = a.next;
                b = b.next;
            }
            return a == null && b == null;
        }

        private static ListNode BuildList(int[] values)
        {
            if (values == null || values.Length == 0) return null;
            var head = new ListNode(values[0]);
            var current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
            return head;
        }
    }
}