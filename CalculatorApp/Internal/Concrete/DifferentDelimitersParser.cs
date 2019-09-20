using CalculatorApp.Internal.Abstract;
using System;
using System.Collections.Generic;

namespace CalculatorApp.Internal.Concrete
{
    public class DifferentDelimitersParser : InputParser
    {
        public string[] SupportedDelimiters { get; private set; }

        public DifferentDelimitersParser(string[] supportedDelimiters)
        {
            SupportedDelimiters = supportedDelimiters;
        }

        public override List<int> Parse(string input)
        {
            List<int> numbers = new List<int>();

            var parsedOperands = input.Split(SupportedDelimiters, StringSplitOptions.None);

            foreach (var operand in parsedOperands)
            {
                int number = 0;
                int.TryParse(operand, out number);
                numbers.Add(number);
            }

            if (numbers.Count == 0 // tried but unsuccessfully parse the input
                && NextInputParser != null)
            {
                numbers = NextInputParser.Parse(input);
            }

            return numbers;
        }

    }
}
