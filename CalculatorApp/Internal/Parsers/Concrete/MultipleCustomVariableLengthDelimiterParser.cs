using CalculatorApp.Internal.Parsers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalculatorApp.Internal.Parsers.Concrete
{
    public class MultipleCustomVariableLengthDelimiterParser : InputParser
    {
        public List<string> Delimiters { get; private set; }

        public override List<int> Parse(string input)
        {
            List<int> numbers = new List<int>();

            // e.g. //[*][!!][r9r]\n11r9r22*33!!44
            Regex regex = new Regex(@"\/\/(?'delimiters'\[.+\])\\n(?'numbers'.*)");
            var match = regex.Match(input);

            var multipleDelimiters = match.Groups["delimiters"].Value;
            var inputNumbers = match.Groups["numbers"].Value;

            Regex delimiterRegex = new Regex(@"\[(.+?)\]");
            var delimiterMatches = delimiterRegex.Matches(multipleDelimiters);
            Delimiters = new List<string>();
            Delimiters.AddRange(delimiterMatches.Select(dm => dm.Groups[1].Value));

            // If there is no even a single char delimiter is provided, the input string is not of right format 
            if (Delimiters == null || Delimiters.Count == 0 || Delimiters.All(d => string.IsNullOrEmpty(d)))
            {
                return numbers;
            }

            var parsedOperands = inputNumbers.Split(Delimiters.ToArray(), StringSplitOptions.None);

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
