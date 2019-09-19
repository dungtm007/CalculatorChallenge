using CalculatorApp.Internal.Abstract;
using CalculatorApp.Internal.Concrete;
using System;
using System.Linq;

namespace CalculatorApp
{
    public class Calculator
    {
        public string Input { get; private set; }

        private InputParser _firstInputParser;
        private InputParser _secondInputParser;

        public Calculator()
        {
            SetupInternalParsers();
        }

        private void SetupInternalParsers()
        {
            int supportedNumberOfOperands = 1;
            _firstInputParser = new CommaDelimiterParser(supportedNumberOfOperands);
        }

        public void ReadInput()
        {
            Console.WriteLine();
            Console.Write("Input: ");
            Input = Console.ReadLine();
        }

        public void Calculate()
        {
            var numbers = _firstInputParser.Parse(Input);
            var sumResult = numbers.Sum();
            Console.WriteLine($"Result: {sumResult}");
        }
    }
}
