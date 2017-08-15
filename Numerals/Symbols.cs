using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals {
    internal static class Symbols
    {
        internal static int LowerLimit { get; } = 1;
        internal static int UpperLimit { get; } = 3999;

        internal static Dictionary<int, string> NumeralsDictionary { get {
                return NumeralsLookup.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            }
        }

        internal static IList<KeyValuePair<int, string>> NumeralsLookup =
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int,string>(1000,"M"),
                new KeyValuePair<int,string>(900,"CM"),
                new KeyValuePair<int,string>(500,"D"),
                new KeyValuePair<int,string>(400,"CD"),
                new KeyValuePair<int,string>(100,"C"),
                new KeyValuePair<int,string>(90,"XC"),
                new KeyValuePair<int,string>(50,"L"),
                new KeyValuePair<int,string>(40,"XL"),
                new KeyValuePair<int,string>(10,"X"),
                new KeyValuePair<int,string>(9,"IX"),
                new KeyValuePair<int,string>(5,"V"),
                new KeyValuePair<int,string>(4,"IV"),
                new KeyValuePair<int,string>(1,"I"),
            };

        internal static Dictionary<string,int> NumbersDictionary { get {
                return NumeralsLookup.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
            } 
        }
            

        internal static IList<KeyValuePair<string, int>> NumbersLookup { get {
                return NumeralsLookup.Select(kvp => new KeyValuePair<string, int>(kvp.Value, kvp.Key)).ToList();
            } 
        }
    }
}