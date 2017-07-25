using Xunit;
using Numerals;

namespace Numerals.Tests 
{
    public class ConvertorTests {

        [Fact]
        public void Returns_I_When_Input_Is_1() {
            var unit = new Convertor();

            string result = unit.ToRomanNumerals(1);

            Assert.Equal("I", result);
        }
    }
}