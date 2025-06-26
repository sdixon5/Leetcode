namespace FindEvenNumberOfDigits
{
    public class OptimalSolutionApproachThree //Using Logarithm
    {
        public int FindNumbers(int[] nums)
        {
            // Counter to count the number of even digit integers
            int evenDigitCount = 0;

            foreach (int num in nums)
            {
                // Compute the number of digits in the num
                int digitCount = (int)Math.Floor(Math.Log10(num)) + 1;

                if (digitCount % 2 == 0)
                    evenDigitCount++;
            }

            return evenDigitCount;
        }
    }
}
