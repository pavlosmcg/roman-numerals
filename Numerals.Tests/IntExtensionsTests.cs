using Xunit;
using RomanNumerals;
using System;
using Xunit.Extensions;
using System.Collections.Generic;

namespace RomanNumerals.Tests 
{
    public class IntExtensionsTests {

        [Fact]
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsLessThanLowerLimit() {
            Assert.Throws<ArgumentOutOfRangeException>(() => 0.ToRomanNumerals());
        }

        [Fact]
        public void ToRomanNumerals_Throws_OutOfRangeException_When_InputIsGreaterThanUpperLimit() {
            Assert.Throws<ArgumentOutOfRangeException>(() => 4000.ToRomanNumerals());
        }

        public static IEnumerable<object[]> ValidValues { get{
            for (int i = 1; i < 4000; i++)
                yield return new object[] {i};
        }}

        [Theory]
        [MemberData(nameof(ValidValues))]
        public void ToRomanNumerals_DoesNotThrow_When_InputIsValid(int input) {
            var ex = Record.Exception(() => input.ToRomanNumerals());
            Assert.Null(ex);
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