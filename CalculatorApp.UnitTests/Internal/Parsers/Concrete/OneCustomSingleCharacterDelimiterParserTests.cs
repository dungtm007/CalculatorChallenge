using CalculatorApp.Internal.Parsers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Parsers.Concrete
{
    public class OneCustomSingleCharacterDelimiterParserTests
    {
        [Theory]
        [InlineData("//;\\n2;5", 7)]
        [InlineData("//e\\n4e,e5e,e6", 15)]
        [InlineData("//*\\n***1***2******3*,adad\\nadada\\n....*1001**adadn\\n\\m", 1007)]
        [InlineData("//\\n4,5,6,7", 0)] // Incorrect format, there is no delimiter
        // Using double back-slashes here for \\n to be consistent with the fact
        // when entering "\n" on console, the input will be captured as "\\n"
        public void Parse_Should_Work_With_Valid_Format(string input, int expectedSum)
        {
            var _differentDelimiterParser = new OneCustomSingleCharacterDelimiterParser();
            var sum = _differentDelimiterParser.Parse(input).Sum();
            Assert.Equal(sum, expectedSum);
        }
    }
}
