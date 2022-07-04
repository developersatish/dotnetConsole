using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetConsole.Random
{
    public class FizzBuzz
    {
        public static void Go()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            fizzBuzz(n);
        }

        static void fizzBuzz(int num)
        {
            for (int n = 1; n <= num; n++)
            {
                bool fizz = n % 3 == 0;
                bool buzz = n % 5 == 0;
                string result = string.Empty;
                if (fizz && buzz)
                {
                    result = "FizzBuzz";
                }
                else if (fizz)
                {
                    result = "Fizz";
                }
                else if (buzz)
                {
                    result = "Buzz";
                }
                else
                {
                    result = n.ToString();
                }
                Console.WriteLine(result);
            }
        }
    }
}
