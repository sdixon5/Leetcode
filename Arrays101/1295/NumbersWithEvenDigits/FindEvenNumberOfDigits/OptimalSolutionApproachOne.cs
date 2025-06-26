namespace FindEvenNumberOfDigits
{
    public class OptimalSolutionApproachOne //Extract Digits
    {
        public int FindNumbers(int[] nums)
        {
            // Counter to count the number of even digit integers
            int evenDigitCount = 0;

            foreach (int num in nums)
            {
                if (hasEvenDigits(num))
                    evenDigitCount++;
            }

            return evenDigitCount;
        }

        private bool hasEvenDigits(int num)
        {
            int digitCount = 0;

            while (num != 0)
            {
                digitCount++;
                num /= 10;
            }

            return (digitCount & 1) == 0; //bitwise operation: can also write 
            /*
             * if digitCount % 2 == 0
             * return true
             * else
             * return false
             */
        }
    }
}
