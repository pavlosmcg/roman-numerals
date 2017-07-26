using Xunit;
using Numerals;
using System;

namespace Numerals.Tests 
{
    public class ConvertorTests {

        [Fact]
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsLessThan1() {
            var unit = new Convertor();

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => unit.ToRomanNumerals(0));
        }

        [Fact]
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsGreaterThan3000() {
            var unit = new Convertor();

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => unit.ToRomanNumerals(3001));
        }

        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(4,"IV")]
        [InlineData(5,"V")]
        [InlineData(6,"VI")]
        [InlineData(7,"VII")]
        [InlineData(8,"VIII")]
        [InlineData(9,"IX")]
        [InlineData(10,"X")]
        public void ToRomanNumerals_Returns_ExpectedResultForNumbersUpTo10(int input, string expected) {
            var unit = new Convertor();

            string result = unit.ToRomanNumerals(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(11,"XI")]
        [InlineData(14,"XIV")]
        [InlineData(18,"XVIII")]
        [InlineData(21,"XXI")]
        [InlineData(39,"XXXIX")]
        [InlineData(41,"XLI")]
        [InlineData(69,"LXIX")]
        [InlineData(83,"LXXXIII")]
        [InlineData(99,"XCIX")]
        [InlineData(100,"C")]
        public void ToRomanNumerals_Returns_ExpectedResultForNumbersUpTo100(int input, string expected) {
            var unit = new Convertor();

            string result = unit.ToRomanNumerals(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(555,"DLV")]
        [InlineData(679,"DCLXXIX")]
        [InlineData(999,"CMXCIX")]
        [InlineData(1001,"MI")]
        [InlineData(1111,"MCXI")]
        [InlineData(1453,"MCDLIII")]
        [InlineData(1983,"MCMLXXXIII")]
        [InlineData(2001,"MMI")]
        [InlineData(2017,"MMXVII")]
        [InlineData(3000,"MMM")]
        public void ToRomanNumerals_Returns_ExpectedResultForNumbersUpTo3000(int input, string expected) {
            var unit = new Convertor();

            string result = unit.ToRomanNumerals(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I",1)]
        [InlineData("II",2)]
        [InlineData("III",3)]
        [InlineData("IV",4)]
        [InlineData("V",5)]
        [InlineData("VI",6)]
        [InlineData("VII",7)]
        [InlineData("VIII",8)]
        [InlineData("IX",9)]
        [InlineData("X",10)]
        [InlineData("XI",11)]
        [InlineData("XIV",14)]
        [InlineData("XVIII",18)]
        [InlineData("XXI",21)]
        [InlineData("XXXIX",39)]
        [InlineData("XLI",41)]
        [InlineData("LXIX",69)]
        [InlineData("LXXXIII",83)]
        [InlineData("XCIX",99)]
        [InlineData("C",100)]
        [InlineData("DLV",555)] 
        [InlineData("DCLXXIX",679)] 
        [InlineData("CMXCIX",999)] 
        [InlineData("MI",1001)]
        [InlineData("MCXI",1111)]
        [InlineData("MCDLIII",1453)]
        [InlineData("MCMLXXXIII",1983)]
        [InlineData("MMI",2001)]
        [InlineData("MMXVII",2017)]
        [InlineData("MMM",3000)]
        public void ToNumber_Returns_ExpectedResultForNumbersUpTo3000(string input, int expected){
            var unit = new Convertor();

            int result = unit.ToNumber(input);

            Assert.Equal(expected, result);
        }
    }
}