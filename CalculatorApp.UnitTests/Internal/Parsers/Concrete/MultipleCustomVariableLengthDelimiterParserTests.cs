using CalculatorApp.Internal.Parsers.Concrete;
using System.Linq;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Parsers.Concrete
{
    public class MultipleCustomVariableLengthDelimiterParserTests
    {
        [Theory]
        [InlineData("//[ab][nm][xyz]\\nnm1xyz2abxyzmn3nm4", 7)]
        [InlineData("//[*][!!][r9r]\\n11r9r22*33!!44", 110)]
        [InlineData("//[*\\n/3][-+-]['+]\\n*\\n/3-+-,1-+-23*\\n/34'+5-+-x6'+,", 32)]
        [InlineData("//[\\n90]\\n10\\n90,,\\n9015\\n9090\\n90,", 115)]
        [InlineData("//*\\n***1***2******3*,adad\\nadada\\n....*1001**adadn\\n\\m", 0)] // Incorrect format
        [InlineData("//[][][]\\n4,5,6,7", 0)] // Incorrect format, there is no delimiter
        [InlineData("//[][][ ]\\n4 5  6   7", 22)] // Delimiter is single whitespace
        // Using double back-slashes here for \\n to be consistent with the fact
        // when entering "\n" on console, the input will be captured as "\\n"
        public void Parse_Should_Work_With_Valid_Format(string input, int expectedSum)
        {
            var _differentDelimiterParser = new MultipleCustomVariableLengthDelimiterParser();
            var sum = _differentDelimiterParser.Parse(input).Sum();
            Assert.Equal(sum, expectedSum);
        }
    }
}
