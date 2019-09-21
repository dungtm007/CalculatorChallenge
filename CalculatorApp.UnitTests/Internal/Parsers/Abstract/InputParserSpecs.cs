using CalculatorApp.Internal.Parsers.Abstract;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Parsers.Abstract
{
    public class InputParserTests
    {
        [Fact]
        public void ParseOrPassToNextInputParserIfNeeded_Should_Pass_To_Next_InputParser_If_Unable_To_Parse()
        {
            InputParser inputParser2 = Substitute.For<InputParser>();
            InputParser inputParser3 = Substitute.For<InputParser>();
            TestInputParser testInputParser = new TestInputParser();
            testInputParser.NextInputParser = inputParser2;
            inputParser2.NextInputParser = inputParser3;
            string testInput = "1,2,3";

            testInputParser.ParseOrPassToNextInputParserIfNeeded(testInput);

            inputParser2.Received().ParseOrPassToNextInputParserIfNeeded(testInput);
            inputParser3.Received().ParseOrPassToNextInputParserIfNeeded(testInput);
        }

        class TestInputParser : InputParser
        {
            public override List<int> Parse(string input)
            {
                return new List<int>();
            }
        }
    }
}
