using CalculatorApp.Internal.Abstract;
using CalculatorApp.Internal.Concrete;
using CalculatorApp.Validators;
using System;
using System.Linq;

namespace CalculatorApp
{
    public class Calculator
    {
        public string Input { get; set; }

        private InputParser _firstInputParser;
        private InputParser _secondInputParser;

        private readonly INumberValidator _numberValidator;

        public Calculator(INumberValidator numberValidator)
        {
            SetupInternalParsers();
            _numberValidator = numberValidator;
        }

        private void SetupInternalParsers()
        {
            _firstInputParser = new DifferentDelimitersParser(supportedDelimiters: new string[] { ",", "\\n" });
            _secondInputParser = new CommaDelimiterParser(supportedNumberOfOperands: -1);
            _firstInputParser.NextInputParser = _secondInputParser;
        }

        public void ReadInput()
        {
            Console.WriteLine();
            Console.Write("Input: ");
            Input = Console.ReadLine();
        }

        public void Calculate()
        {
            var numbers = _firstInputParser.ParseOrPassToNextInputParserIfNeeded(Input);
            if (!_numberValidator.IsValid(numbers))
            {
                throw new ArgumentException($"{_numberValidator.ViolatedConditionName}: {string.Join(',', _numberValidator.InvalidNumbers)}");
            }
            var sumResult = numbers.Sum();
            Console.WriteLine($"Result: {sumResult}");
        }
    }
}
