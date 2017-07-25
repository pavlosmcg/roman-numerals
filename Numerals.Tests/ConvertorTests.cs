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
    }
}