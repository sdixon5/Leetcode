namespace SquaresOfSortedArray
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = (int)(Math.Pow(Math.Abs(nums[i]), 2));
            }

            Array.Sort(result);
            return result;
        }
    }
}
