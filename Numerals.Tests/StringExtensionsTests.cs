using System;
using Xunit;

namespace RomanNumerals.Tests{
    public class StringExtensionsTests {
        [Theory]
        [ClassData(typeof(TestData))]
        public void ToNumber_Returns_ExpectedResultForValidNumeralsUpTo3999(int expected, string input){
            int result = input.ToNumber();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToNumber_Throws_ExceptionWithMessage_When_InputIsNotValidRomanNumeral(){
            var input = "FRAMISTAN";
            var exception = Record.Exception(() => input.ToNumber());

            Assert.Contains(input,exception.Message);
        }

        [Fact]
        public void ToNumber_Throws_FormatException_When_InputContainsNonValidCharacters(){
            Assert.Throws<FormatException>(() => "BLORG".ToNumber());
        }

        [Theory]
        [InlineData("XVIV")]
        [InlineData("MDCDIII")]
        [InlineData("LXLIV")]
        public void ToNumber_Throws_FormatException_When_InputRepeatsNonRepeatableCharacters(string input){
            Assert.Throws<FormatException>(() => input.ToNumber());
        }

        [Theory]
        [InlineData("XXXXI")]
        [InlineData("MCMXXXXIII")]
        [InlineData("IIII")]
        [InlineData("VIIII")]
        public void ToNumber_Throws_FormatException_When_InputContains4ConsecutiveRepeatedCharacters(string input){
            Assert.Throws<FormatException>(() => input.ToNumber());
        }
    }
}