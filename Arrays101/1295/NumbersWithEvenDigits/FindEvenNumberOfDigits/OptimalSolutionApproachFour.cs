namespace FindEvenNumberOfDigits
{
    public class OptimalSolutionApproachFour //Constraint Analysis
    {
        public int FindNumbers(int[] nums)
        {
            // Counter to count the number of even digit integers
            int evenDigitCount = 0;

            foreach (int num in nums)
            {
                if ((num >= 10 && num <= 99) || (num >= 1000 && num <= 9999) || num == 100000)
                    evenDigitCount++;
            }

            return evenDigitCount;
        }
    }
}
