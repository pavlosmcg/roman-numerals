using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerals 
{
    public class Convertor
    {
        private Dictionary<int, string> romanNumerals 
            = new Dictionary<int, string>{
                    {1,"I"},
                    {4,"IV"},
                    {5,"V"},
                }.Reverse().ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        public string ToRomanNumerals(int input) {
            if (input < 1 || input > 1000)
                throw new ArgumentOutOfRangeException(); 
            
            string numeral;
            if (romanNumerals.TryGetValue(input, out numeral)){
                return numeral;
            }
            
            foreach(var item in romanNumerals) {
                int value = item.Key;
                if (value < input) {
                    int remainder = input - value;
                    return romanNumerals[value] + ToRomanNumerals(remainder);
                }
            }

            return null;
        }
    }
}