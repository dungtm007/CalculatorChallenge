using CalculatorApp.Internal.Filters;
using CalculatorApp.Internal.Parsers.Abstract;
using CalculatorApp.Internal.Parsers.Concrete;
using CalculatorApp.Internal.Validators;
using System;
using System.Linq;

namespace CalculatorApp
{
    public class Calculator
    {
        public string Input { get; set; }

        private InputParser _inputParser1;
        private InputParser _inputParser2;
        private InputParser _inputParser3;

        private readonly INumberValidator _numberValidator;
        private readonly INumberFilter _numberFilter;

        public Calculator(INumberValidator numberValidator, INumberFilter numberFilter)
        {
            SetupInternalParsers();

            _numberValidator = numberValidator;
            _numberFilter = numberFilter;
        }

        private void SetupInternalParsers()
        {
            _inputParser1 = new OneCustomSingleCharacterDelimiterParser();
            _inputParser2 = new DifferentDelimitersParser(supportedDelimiters: new string[] { ",", "\\n" });
            _inputParser3 = new CommaDelimiterParser(supportedNumberOfOperands: -1);

            _inputParser1.NextInputParser = _inputParser2;
            _inputParser2.NextInputParser = _inputParser3;
        }

        public void ReadInput()
        {
            Console.WriteLine();
            Console.Write("Input: ");
            Input = Console.ReadLine();
        }

        public void Calculate()
        {
            var numbers = _inputParser1.ParseOrPassToNextInputParserIfNeeded(Input);

            if (!_numberValidator.IsValid(numbers))
            {
                throw new ArgumentException(
                    $"{_numberValidator.ViolatedConditionName}: {string.Join(',', _numberValidator.InvalidNumbers)}");
            }

            var finalNumbers = _numberFilter.Filter(numbers);

            var sumResult = finalNumbers.Sum();

            Console.WriteLine($"Result: {sumResult}");
        }
    }
}
