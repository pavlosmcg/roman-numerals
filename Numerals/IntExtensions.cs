using System;
using System.Collections.Generic;
using System.Linq;
using static RomanNumerals.Symbols;

namespace RomanNumerals {
    public static class IntExtensions {

        public static string ToRomanNumerals(this int input) {
            if (input < LowerLimit || input > UpperLimit)
                throw new ArgumentOutOfRangeException(nameof(input), input,
                    $"Input must be between '{LowerLimit}' and '{UpperLimit}'."); 
            
            string numeral;
            if (NumbersToNumerals.TryGetValue(input, out numeral))
                return numeral;
            
            foreach(var item in NumbersToNumerals) {
                int value = item.Key;
                if (value < input) {
                    int remainder = input - value;
                    return NumbersToNumerals[value] + remainder.ToRomanNumerals();
                }
            }

            return null;
        }
    }
}