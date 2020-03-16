using System;
using System.Text.RegularExpressions;

namespace CalculateurChaine
{
    public class Calculateur
    {
        public int AddRegex(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string workingNumbers = numbers;
            string[] separators = new[] { ",", "\n" };
            string separatorRegex = "^\\/\\/(.+)\n(.*)$";
            Regex regex = new Regex(separatorRegex, RegexOptions.IgnoreCase);

            var matches = regex.Match(numbers);
            if (matches.Success)
            {
                separators = new[] { matches.Groups[1].Value };
                workingNumbers = matches.Groups[2].Value;
            }

            var numberTab = workingNumbers.Split(separators, StringSplitOptions.None);
            int nombre = 0;
            foreach(string number in numberTab)
            {
                int parseNumber;
                try
                {
                    parseNumber = int.Parse(number);
                }
                catch (FormatException formatException)
                {
                    throw new EspaceException();    
                }

                nombre += parseNumber > 1000 ? 0: parseNumber;
            }
            return nombre;                
        }

        public int Add(string numbers)
        {
            return AddRegex(numbers);
            string workingNumbers = numbers;
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            char[] separators = new[] { ',', '\n' };
            if(numbers.Length > 3 && numbers.StartsWith("//"))
            {
                separators = new[] { numbers[2] };
                workingNumbers = numbers.Split('\n')[1];
            }          

            var numberTab = workingNumbers.Split(separators);
            int nombre = 0;
            foreach (string number in numberTab)
            {
                nombre += int.Parse(number);
            }
            return nombre;
        }
    }
}
