namespace MaxConsecutiveOnes
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int consecutiveCount = 0;

            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    consecutiveCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, consecutiveCount);
                    consecutiveCount = 0;
                }
            }

            // Final check in case the array ends with 1s
            maxCount = Math.Max(maxCount, consecutiveCount);

            return maxCount;
        }
    }
}
