namespace KDistantIndicies
{
    public class Solution
    {
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {

            IList<int> indicies = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == key && Math.Abs(i - j) <= k)
                    {
                        indicies.Add(i);
                        break;
                    }
                }
            }

            return indicies;
        }
    }
}
