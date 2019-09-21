﻿using CalculatorApp.Internal.Parsers.Abstract;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CalculatorApp.Internal.Parsers.Concrete
{
    public class OneCustomSingleCharacterDelimiterParser : InputParser
    {
        public string Delimiter { get; private set; }

        public override List<int> Parse(string input)
        {
            List<int> numbers = new List<int>();

            // e.g. //;\n2;5
            Regex regex = new Regex(@"\/\/(?'delimiter'.)\\n(?'numbers'.*)");
            var match = regex.Match(input);
            Delimiter = match.Groups["delimiter"].Value;
            var inputNumbers = match.Groups["numbers"].Value;

            // If no single char delimiter is provided, the input string is not of right format 
            if (string.IsNullOrEmpty(Delimiter))
            {
                return numbers;
            }

            var parsedOperands = inputNumbers.Split(Delimiter);

            foreach (var operand in parsedOperands)
            {
                int number;
                int.TryParse(operand, out number);
                numbers.Add(number);
            }

            return numbers;
        }
    }
}
