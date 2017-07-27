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
            
            return NumbersToNumerals
                .Select(kvp => 
                    new {number=kvp.Key, numeral=kvp.Value, remainder=input-kvp.Key})
                .Where(i => i.number < input)
                .Select(i => string.Concat(i.numeral, i.remainder.ToRomanNumerals()))
                .First();
        }
    }
}