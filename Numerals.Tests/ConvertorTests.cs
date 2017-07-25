using Xunit;
using Numerals;

namespace Numerals.Tests 
{
    public class ConvertorTests {

        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(4,"IV")]
        public void Returns_Expected_Result(int input, string expected) {
            var unit = new Convertor();

            string result = unit.ToRomanNumerals(input);

            Assert.Equal(expected, result);
        }
    }
}