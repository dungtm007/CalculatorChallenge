
using CalculatorApp.Internal.Parsers.Concrete;
using System.Linq;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Parsers.Concrete
{
    public class DifferentDelimitersParserTests
    {
        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1,,2,,,\n3", 6)]
        [InlineData("sadafa\n1,,,4", 5)]
        [InlineData(",,,hhh2\n3,,,\n\n4,\n,\n,5\n//re.ad..,\\m\n6,,,.", 18)]
        [InlineData("1\n2,3,4\n5,6", 21)]
        public void Parse_Should_Work_With_Valid_Format(string input, int expectedSum)
        {
            var _differentDelimiterParser = new DifferentDelimitersParser(supportedDelimiters: new string[] { ",", "\n" });
            var sum = _differentDelimiterParser.Parse(input).Sum();
            Assert.Equal(sum, expectedSum);
        }
    }
}
