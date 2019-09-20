using CalculatorApp.Internal.Abstract;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Abstract
{
    public class InputParserTests
    {
        [Fact]
        public void ParseOrPassToNextInputParserIfNeeded_Should_Pass_To_Next_InputParser_If_Unable_To_Parse()
        {
            InputParser nextInputParser = Substitute.For<InputParser>();
            TestInputParser testInputParser = new TestInputParser(nextInputParser);
            string testInput = "1,2,3";
            testInputParser.ParseOrPassToNextInputParserIfNeeded(testInput);
            nextInputParser.Received(1).Parse(testInput);
        }

        class TestInputParser : InputParser
        {
            public TestInputParser(InputParser nextInputParser)
            {
                NextInputParser = nextInputParser;
            }

            public override List<int> Parse(string input)
            {
                return new List<int>();
            }
        }
    }
}
