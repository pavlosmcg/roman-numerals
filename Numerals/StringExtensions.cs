using System;
using static RomanNumerals.Symbols;

namespace RomanNumerals {
    public static class StringExtensions {
        public static int ToNumber(this string input) {
            int number;
            if (NumeralsToNumbers.TryGetValue(input, out number))
                return number;
            
            foreach (var item in NumeralsToNumbers) {
                string numeral = item.Key;

                if (input.Length < numeral.Length)
                    continue;

                if (input.Substring(0,numeral.Length) == numeral)
                    return NumeralsToNumbers[numeral] 
                        + input.Substring(numeral.Length).ToNumber();
            }
            
            throw new FormatException($"'{input}' is not a valid Roman numeral.");
        }
    }
}