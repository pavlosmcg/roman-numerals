using System;
using Xunit;

namespace RomanNumerals.Tests{
    public class StringExtensionsTests {
        [Fact]
        public void ToNumber_Throws_FormatException_When_InputIsNotValidRomanNumeral(){
            Assert.Throws<FormatException>(() => "BLORG".ToNumber());
        }

        [Fact]
        public void ToNumber_Throws_ExceptionWithMessage_When_InputIsNotValidRomanNumeral(){
            var input = "FRAMISTAN";
            var exception = Record.Exception(() => input.ToNumber());

            Assert.Contains(input,exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestData))]
        public void ToNumber_Returns_ExpectedResultForNumbersUpTo3999(int expected, string input){
            int result = input.ToNumber();

            Assert.Equal(expected, result);
        }
    }
}