namespace RunningSumOf1dArray
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            List<int> output = new List<int>();

            int current = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                current = current + nums[i];
                output.Add(current);
            }

            return output.ToArray();
        }
    }
}
