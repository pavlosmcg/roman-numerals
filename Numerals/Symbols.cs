using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals {
    internal static class Symbols
    {
        internal static int LowerLimit { get; } = 1;
        internal static int UpperLimit { get; } = 3999;

        internal static Dictionary<int, string> NumbersToNumerals { get; }
            = new Dictionary<int, string>{
                {1000,"M"},
                {900,"CM"},
                {500,"D"},
                {400,"CD"},
                {100,"C"},
                {90,"XC"},
                {50,"L"},
                {40,"XL"},
                {10,"X"},
                {9,"IX"},
                {5,"V"},
                {4,"IV"},
                {1,"I"},
            };

        private static Dictionary<string,int> numeralsToNumbers 
            = NumbersToNumerals.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

        internal static Dictionary<string,int> NumeralsToNumbers { get; } = numeralsToNumbers;
    }
}