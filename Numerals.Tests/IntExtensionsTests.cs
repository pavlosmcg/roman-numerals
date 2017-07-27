using Xunit;
using RomanNumerals;
using System;

namespace RomanNumerals.Tests 
{
    public class IntExtensionsTests {

        [Fact]
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsLessThan1() {
            Assert.Throws<ArgumentOutOfRangeException>(() => 0.ToRomanNumerals());
        }

        [Fact]
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsGreaterThan3000() {
            Assert.Throws<ArgumentOutOfRangeException>(() => 3001.ToRomanNumerals());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(8999)]
        public void ToRomanNumerals_Throws_ExceptionWithMessage_When_InputIsOutOfRange(int input){
            var exception = Record.Exception(() => input.ToRomanNumerals());

            Assert.Contains(input.ToString(),exception.Message);
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
            string result = input.ToRomanNumerals();

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
            string result = input.ToRomanNumerals();

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
            string result = input.ToRomanNumerals();

            Assert.Equal(expected, result);
        }        
    }
}