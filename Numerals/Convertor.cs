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
                    {1400,"MCD"},
                    {1500,"MD"},
                    {1900,"MCM"},
                    {2000,"MM"},
                    {2400,"MMCD"},
                    {2500,"MMD"},
                    {2900,"MMCM"},
                    {3000,"MMM"}
                }.Reverse().ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        public string ToRomanNumerals(int input) {
            if (input < 1 || input > 3000)
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