using CalculatorApp.Internal.Abstract;
using System.Collections.Generic;

namespace CalculatorApp.Internal.Concrete
{
    public class CommaDelimiterParser : InputParser
    {
        public int SupportedNumberOfOperands { get; private set; }

        public CommaDelimiterParser(int supportedNumberOfOperands)
        {
            SupportedNumberOfOperands = supportedNumberOfOperands; // -1, 0, 1 all mean unlimited
        }

        public override List<int> Parse(string input)
        {
            List<int> numbers = new List<int>();

            var parsedOperands = input.Split(',');

            foreach (var operand in FilterSupportedNumberOfOperands(parsedOperands))
            {
                int number;
                int.TryParse(operand, out number);
                numbers.Add(number);
            }

            return numbers;
        }

        private IEnumerable<string> FilterSupportedNumberOfOperands(string[] operands)
        {
            int count = 0;
            foreach (var operand in operands)
            {                
                yield return operand;
                if (SupportedNumberOfOperands > 1) // less than or equal to 1 means supporting unlimited numbers 
                {
                    if (++count == SupportedNumberOfOperands)
                    {
                        break;
                    }
                }
            }
        }

    }
}
