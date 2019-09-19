using CalculatorApp.Internal.Abstract;
using System.Collections.Generic;

namespace CalculatorApp.Internal.Concrete
{
    public class CommaDelimiterParser : InputParser
    {
        public int SupportedNumberOfOperands { get; private set; }

        public CommaDelimiterParser(int supportedNumberOfOperands)
        {
            SupportedNumberOfOperands = supportedNumberOfOperands; // -1 means unlimited
        }

        public override List<int> Parse(string input)
        {
            List<int> numbers = new List<int>();

            var parsedOperands = input.Split(',');

            foreach (var operand in FilterSupportedNumberOfOperands(parsedOperands))
            {
                int number;
                if (int.TryParse(operand, out number))
                {
                    numbers.Add(number);
                }
            }

            if (numbers.Count == 0 // tried but unsuccessfully parse the input
                && NextInputParser != null)
            {
                numbers = NextInputParser.Parse(input);
            }

            return numbers;
        }

        private IEnumerable<string> FilterSupportedNumberOfOperands(string[] operands)
        {
            int count = 0;
            foreach (var operand in operands)
            {                
                yield return operand;
                if (++count == SupportedNumberOfOperands)
                {
                    break;
                }
            }
        }

    }
}
