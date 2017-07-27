using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals {
    public static class IntExtensions {
        internal static Dictionary<int, string> romanNumerals 
            = new Dictionary<int, string>{
                    {1,"I"},
                    {4,"IV"},
                    {5,"V"},
                    {9,"IX"},
                    {10,"X"},
                    {40,"XL"},
                    {50,"L"},
                    {90,"XC"},
                    {100,"C"},
                    {400,"CD"},
                    {500,"D"},
                    {900,"CM"},
                    {1000,"M"},
                }.Reverse().ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        public static string ToRomanNumerals(this int input) {
            int upper = 3999;
            int lower = 1;
            if (input < 1 || input > 3999)
                throw new ArgumentOutOfRangeException(nameof(input), input,
                    $"Input must be between '{lower}' and '{upper}'."); 
            
            string numeral;
            if (romanNumerals.TryGetValue(input, out numeral)){
                return numeral;
            }
            
            foreach(var item in romanNumerals) {
                int value = item.Key;
                if (value < input) {
                    int remainder = input - value;
                    return romanNumerals[value] + remainder.ToRomanNumerals();
                }
            }

            return null;
        }
    }
}