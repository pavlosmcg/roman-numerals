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
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsGreaterThan3999() {
            Assert.Throws<ArgumentOutOfRangeException>(() => 4000.ToRomanNumerals());
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
        [ClassData(typeof(TestData))]
        public void ToRomanNumerals_Returns_ExpectedResultForNumbersUpTo3999(string expected, int input) {
            string result = input.ToRomanNumerals();

            Assert.Equal(expected, result);
        }        
    }
}