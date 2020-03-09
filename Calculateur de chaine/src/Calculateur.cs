using System;

namespace CalculateurChaine
{
    public class Calculateur
    {
        public int Add(string numbers)
        {
            int result = 0;
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return result;
            }
           
            string[] numberTab = numbers.Split(',','\n');
            foreach (string number in numberTab)
            {
                result += int.Parse(number);
            }
            return result;
        }
    }
}
