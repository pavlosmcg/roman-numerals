using System.Collections.Generic;

namespace Numerals 
{
    public class Convertor
    {
        private Dictionary<int, string> romanNumerals 
            = new Dictionary<int, string>{
                    {1,"I"},
                    {2,"II"},
                    {3,"III"},
                    {4,"IV"}
                };

        public string ToRomanNumerals(int input) {
            return romanNumerals[input];
        }
    }
}