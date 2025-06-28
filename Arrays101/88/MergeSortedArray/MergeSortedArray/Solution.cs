namespace MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //replace placeholder 0s, then sort
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }

            //two pointer sort
            for (int i = 0; i < nums1.Length; i++)
            {
                if (i + 1 >= nums1.Length)
                {
                    break;
                }

                int current = nums1[i];
                int next = nums1[i + 1];

                if (next < current)
                {
                    nums1[i] = next;
                    nums1[i + 1] = current;
                    i = -1; //reset to start
                }
            }

            // If m == 0, move all zeros to the end
            if (m == 0)
            {
                int insertPos = 0;
                // Move non-zero elements to the front
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (nums1[i] != 0)
                    {
                        nums1[insertPos++] = nums1[i];
                    }
                }
                // Fill the rest with zeros
                while (insertPos < nums1.Length)
                {
                    nums1[insertPos++] = 0;
                }
            }
        }
    }
}
