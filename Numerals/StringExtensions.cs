using System;

namespace RomanNumerals {
    public static class StringExtensions {
        public static int ToNumber(this string input) {
            foreach (var kvp in IntExtensions.romanNumerals)
            {
                string numeral = kvp.Value;
                if (input == numeral)
                    return kvp.Key;

                if (input.Length < numeral.Length)
                    continue;

                if (input.Substring(0,numeral.Length) == numeral)
                {
                    return kvp.Key + input.Substring(numeral.Length).ToNumber(); 
                }
            }
            
            throw new FormatException($"'{input}' is not a valid Roman numeral.");
        }
    }
}