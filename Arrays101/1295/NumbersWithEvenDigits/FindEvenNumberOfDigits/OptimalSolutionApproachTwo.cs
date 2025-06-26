namespace FindEvenNumberOfDigits
{
    public class OptimalSolutionApproachTwo //Convert to String
    {
        public int FindNumbers(int[] nums)
        {
            // Counter to count the number of even digit integers
            int evenDigitCount = 0;

            foreach (int num in nums)
            {
                // Convert num to string and find its length
                int length = num.ToString().Length;

                if (length % 2 == 0)
                    evenDigitCount++;
            }

            return evenDigitCount;
        }
    }
}
