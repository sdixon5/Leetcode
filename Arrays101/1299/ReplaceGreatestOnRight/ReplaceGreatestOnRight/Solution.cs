namespace ReplaceGreatestOnRight
{
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            int largestToRight = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && j > i)
                    {
                        if (arr[j] >= largestToRight)
                        {
                            largestToRight = arr[j];
                        }    
                    }
                }

                arr[i] = largestToRight;

                largestToRight = -1;
            }

            return arr;
        }
    }
}
