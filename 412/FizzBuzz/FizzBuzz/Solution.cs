namespace FizzBuzz
{
    public class Solution
    {
        //Original solution. But it's better to concatenate the strings incase
        //more conditions are added in the future.
        public IList<string> FizzBuzzOriginal(int n)
        {
            var result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

        public IList<string> FizzBuzzOptimal(int n)
        {
            List<string> result = new List<string>(n);

            for (int i = 1; i <= n; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;

                string currStr = "";

                if (divisibleBy3)
                {
                    currStr += "Fizz";
                }

                if (divisibleBy5)
                {
                    currStr += "Buzz";
                }

                if (string.IsNullOrEmpty(currStr))
                {
                    currStr += i.ToString();
                }

                result.Add(currStr);
            }

            return result;
        }
    }
}
