namespace DuplicateZeros
{
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            //duplicate zeros in place
            //shift all elements to the right
            //keep original length of the array

            int arrayLength = arr.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (arr[i] == 0)
                {
                    // If we encounter a zero, we need to shift elements to the right.
                    // We can only do this if we have enough space in the array.
                    if (i < arrayLength - 1)
                    {
                        arr = ShiftRight(arr, arrayLength - 1, i);
                        arr[i + 1] = 0; // Duplicate the zero
                        i++; // Skip the next index since we just added a zero
                    }
                }
            }

        }

        private int[] ShiftRight(int[] array, int arrayLength, int stoppingPosition)
        {
            for (int i = arrayLength; i > stoppingPosition; i--)
            {
                if (i != arrayLength)
                {
                    // Shift each element one position to the right.
                    array[i + 1] = array[i];
                }
            }

            return array;
        }
    }
}
