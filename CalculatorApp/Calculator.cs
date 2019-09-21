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
        private InputParser _inputParser4;
        private InputParser _inputParser5;

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
            _inputParser1 = new MultipleCustomVariableLengthDelimiterParser();
            _inputParser2 = new OneCustomVariableLengthDelimiterParser();
            _inputParser3 = new OneCustomSingleCharacterDelimiterParser();
            _inputParser4 = new DifferentDelimitersParser(supportedDelimiters: new string[] { ",", "\\n" });
            _inputParser5 = new CommaDelimiterParser(supportedNumberOfOperands: -1);

            _inputParser1.NextInputParser = _inputParser2;
            _inputParser2.NextInputParser = _inputParser3;
            _inputParser3.NextInputParser = _inputParser4;
            _inputParser4.NextInputParser = _inputParser5;
        }

        public void ReadInput()
        {
            Console.WriteLine();
            Console.Write("Input: ");
            Input = Console.ReadLine();
        }

        public int Calculate()
        {
            var numbers = _inputParser1.ParseOrPassToNextInputParserIfNeeded(Input);

            if (!_numberValidator.IsValid(numbers))
            {
                throw new ArgumentException(
                    $"{_numberValidator.ViolatedConditionName}: {string.Join(',', _numberValidator.InvalidNumbers)}");
            }

            var finalNumbers = _numberFilter.Filter(numbers);

            var sumResult = finalNumbers?.Sum() ?? 0;

            Console.WriteLine($"Result: {sumResult}");

            return sumResult;
        }
    }
}
