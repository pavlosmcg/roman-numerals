using System;
using System.Linq;
using static RomanNumerals.Symbols;

namespace RomanNumerals {
    public static class StringExtensions {
        private static string ErrorText = "'{0}' is not a valid Roman numeral.";
        public static int ToNumber(this string input) {
            CheckForNonRepeatableChars(input);
            CheckForRepeatedConsecutiveChars(input);

            return CalculateNumber(input);
        }

        private static int CalculateNumber(string input){
            int number;
            if (NumbersDictionary.TryGetValue(input, out number))
                return number;

            foreach (var item in NumbersLookup) {
                string numeral = item.Key;

                if (input.Length < numeral.Length)
                    continue;

                if (input.Substring(0,numeral.Length) == numeral)
                    return NumbersDictionary[numeral] 
                        + CalculateNumber(input.Substring(numeral.Length));
            }
            
            throw new FormatException(string.Format(ErrorText,input));
        }

        private static void CheckForRepeatedConsecutiveChars(string input) {
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                count = (input[i] == input[i-1]) ? ++count : 1;
                if (count > 3)
                    throw new FormatException(string.Format(ErrorText,input));
            }
        }

        private static void CheckForNonRepeatableChars(string input) {
            bool repeated = input
                .Where(c => new[]{'V', 'L', 'D'}.Contains(c))
                .GroupBy(c => c)
                .Any(g => g.Count() > 1);
            if (repeated)
                throw new FormatException(string.Format(ErrorText,input));
        }
    }
}