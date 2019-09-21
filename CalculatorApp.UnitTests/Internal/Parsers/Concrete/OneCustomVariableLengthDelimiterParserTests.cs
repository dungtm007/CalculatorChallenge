using CalculatorApp.Internal.Parsers.Concrete;
using System.Linq;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Parsers.Concrete
{
    public class OneCustomVariableLengthDelimiterParserTests
    {
        [Theory]
        [InlineData("//[***]\\n11***22***33", 66)]
        [InlineData("//[\\n]\\n\\n\\n\\n,\\n4\\n,,\\n5\\nsadad,", 9)]
        [InlineData("//[\\n90]\\n10\\n90,,\\n9015\\n9090\\n90,", 115)] // delimiter is "\\n90"
        [InlineData("//*\\n***1***2******3*,adad\\nadada\\n....*1001**adadn\\n\\m", 0)] // Incorrect format
        [InlineData("//[]\\n4,5,6,7", 0)] // Incorrect format, there is no delimiter
        // Using double back-slashes here for \\n to be consistent with the fact
        // when entering "\n" on console, the input will be captured as "\\n"
        public void Parse_Should_Work_With_Valid_Format(string input, int expectedSum)
        {
            var _differentDelimiterParser = new OneCustomVariableLengthDelimiterParser();
            var sum = _differentDelimiterParser.Parse(input).Sum();
            Assert.Equal(sum, expectedSum);
        }
    }
}
