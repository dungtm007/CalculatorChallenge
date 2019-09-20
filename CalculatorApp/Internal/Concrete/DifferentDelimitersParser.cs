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

            return numbers;
        }

    }
}
