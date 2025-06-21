using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz
{
    public class OptimalSolution
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> answer = new List<string>(n);

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

                answer.Add(currStr);
            }

            return answer;
        }
    }
}
