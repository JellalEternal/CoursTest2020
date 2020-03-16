using System;

namespace FizzBuzzImpl
{
    public class FizzBuzzClass
    {
        public string FizzBuzz(int number)
        {
            string result = string.Empty;
            if (number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number % 5 == 0)
            {
                result +="Buzz";
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}
