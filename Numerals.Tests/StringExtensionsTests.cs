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
        [InlineData("MCMIII",1903)]
        [InlineData("MCMLXXXIII",1983)]
        [InlineData("MMI",2001)]
        [InlineData("MMXVII",2017)]
        [InlineData("MMM",3000)]
        [InlineData("MMMCXVI",3116)]
        [InlineData("MMMDCCXXVIII",3728)]
        [InlineData("MMMCMXCIX",3999)]
        public void ToNumber_Returns_ExpectedResultForNumbersUpTo3999(string input, int expected){
            int result = input.ToNumber();

            Assert.Equal(expected, result);
        }
    }
}