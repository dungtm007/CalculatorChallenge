using CalculatorApp.Internal.Parsers.Concrete;
using System.Linq;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Parsers.Concrete
{
    public class CommaDelimiterParserTests
    {
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("1,,2", 3)]
        [InlineData("sadafa,,,4", 4)]
        [InlineData(",,,3,,,6,,sadad,1,hhh,", 10)]
        [InlineData("", 0)]
        [InlineData("dada,19adada", 0)]
        [InlineData("1, 2   ,3   ,4,5,6,  7,8,9,10,11,12", 78)]
        [InlineData("1\n2,3,4\n5,6", 9)]
        public void Parse_Unlimited_Operands_Should_Work_With_Valid_Format(string input, int expectedSum)
        {
            var _commaDelimiterParser = new CommaDelimiterParser(supportedNumberOfOperands: -1);
            var sum = _commaDelimiterParser.Parse(input).Sum();
            Assert.Equal(sum, expectedSum);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("1,,2", 1)]
        [InlineData("sadafa,,,4", 0)]
        [InlineData("5,-1,,3,,,6,,sadad,1,hhh,", 4)]
        [InlineData("", 0)]
        [InlineData("dada,19adada,8", 0)]
        [InlineData("1, 2   ,3   ,4,5,6,  7,8,9,10,11,12", 3)]
        [InlineData("1\n2,3,4\n5,6", 3)]
        public void Parse_Limited_Operands_Should_Work_With_Valid_Format(string input, int expectedSum)
        {
            var _commaDelimiterParser = new CommaDelimiterParser(supportedNumberOfOperands: 2);
            var sum = _commaDelimiterParser.Parse(input).Sum();
            Assert.Equal(sum, expectedSum);
        }

    }
}
