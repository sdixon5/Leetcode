namespace RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int currentIndex = i;
                
                if (nums[i] == val)
                {
                    while (!(currentIndex + 1 > nums.Length - 1))
                    {
                        if (nums[currentIndex + 1] != val)
                        {
                            nums[currentIndex] = nums[currentIndex + 1];
                            nums[currentIndex + 1] = val;
                        }

                        currentIndex++;
                    }
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != val)
                {
                    k++;
                }

                if (nums[i] == val)
                {
                    nums[i] = 0;
                }
            }

            return k;
        }
    }
}
