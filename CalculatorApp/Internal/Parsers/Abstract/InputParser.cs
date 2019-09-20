using System.Collections.Generic;

namespace CalculatorApp.Internal.Parsers.Abstract
{
    /// <summary>
    /// Pattern: Chain of responsibility.
    /// To have a collection of different input parsers
    /// sequentailly try to parse an input string, until one parser 
    /// can realize its supported format and be able to parse
    /// input string and return an array of operand numbers
    /// </summary>
    public abstract class InputParser
    {
        public InputParser NextInputParser { get; set; }
        public abstract List<int> Parse(string input);  
        public List<int> ParseOrPassToNextInputParserIfNeeded(string input)
        {
            List<int> numbers = Parse(input);
            if (numbers.Count == 0 // tried but unsuccessfully parse the input
                && NextInputParser != null)
            {
                numbers = NextInputParser.Parse(input);
            }
            return numbers;
        }
    }
}
