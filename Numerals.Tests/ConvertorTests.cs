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
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsGreaterThan1000() {
            var unit = new Convertor();

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => unit.ToRomanNumerals(1001));
        }

        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(4,"IV")]
        public void ToRomanNumerals_Returns_ExpectedResult(int input, string expected) {
            var unit = new Convertor();

            string result = unit.ToRomanNumerals(input);

            Assert.Equal(expected, result);
        }
    }
}