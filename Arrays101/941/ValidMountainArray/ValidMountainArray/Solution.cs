namespace ValidMountainArray
{
    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            bool result = true;

            if (arr.Length >= 3)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != arr.Length-1)
                    {
                        if (!(arr[i] < arr[i + 1] || arr[i] > arr[i + 1]))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
