namespace RemoveDuplicatedSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    nums[i] = -101;
                }
                else
                {
                    map[nums[i]] = 1;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int currentIndex = i;

                if (nums[i] == -101)
                {
                    while (!(currentIndex + 1 > nums.Length - 1))
                    {
                        if (nums[currentIndex + 1] != -101)
                        {
                            nums[currentIndex] = nums[currentIndex + 1];
                            nums[currentIndex + 1] = -101;
                        }

                        currentIndex++;
                    }
                }
            }

            return map.Keys.Count;
        }
    }
}
