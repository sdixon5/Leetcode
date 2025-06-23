namespace NumberOfStepsToReduceANumberToZero
{
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            int numberOfSteps = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2; // If the number is even, divide it by 2
                }
                else
                {
                    num --; // If the number is odd, subtract 1
                }
                numberOfSteps++; // Increment the step count
            }

            return numberOfSteps; // Return the total number of steps taken to reduce the number to zero
        }
    }
}
