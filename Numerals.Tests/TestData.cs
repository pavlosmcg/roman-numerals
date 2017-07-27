using System;
using System.Collections;
using System.Collections.Generic;

namespace RomanNumerals.Tests {
    public class TestData : IEnumerable<object[]> {
        private IList<object[]> Data = new List<object[]>{
            new object [] {"I",1},
            new object [] {"II",2},
            new object [] {"III",3},
            new object [] {"IV",4},
            new object [] {"V",5},
            new object [] {"VI",6},
            new object [] {"VII",7},
            new object [] {"VIII",8},
            new object [] {"IX",9},
            new object [] {"X",10},
            new object [] {"XI",11},
            new object [] {"XIV",14},
            new object [] {"XVIII",18},
            new object [] {"XXI",21},
            new object [] {"XXXIX",39},
            new object [] {"XLI",41},
            new object [] {"LXIX",69},
            new object [] {"LXXXIII",83},
            new object [] {"XCIX",99},
            new object [] {"C",100},
            new object [] {"DLV",555}, 
            new object [] {"DCLXXIX",679}, 
            new object [] {"CMXCIX",999}, 
            new object [] {"MI",1001},
            new object [] {"MCXI",1111},
            new object [] {"MCDLIII",1453},
            new object [] {"MCMIII",1903},
            new object [] {"MCMLXXXIII",1983},
            new object [] {"MMI",2001},
            new object [] {"MMXVII",2017},
            new object [] {"MMM",3000},
            new object [] {"MMMCXVI",3116},
            new object [] {"MMMDCCXXVIII",3728},
            new object [] {"MMMCMXCIX",3999},
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
