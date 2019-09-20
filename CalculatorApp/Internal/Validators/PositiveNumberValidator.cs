using System.Collections.Generic;

namespace CalculatorApp.Internal.Validators
{
    public class PositiveNumberValidator : INumberValidator
    {
        public List<int> InvalidNumbers { get; private set; }

        public string ViolatedConditionName => "Negative Number";

        public bool IsValid(List<int> numbers)
        {
            InvalidNumbers = numbers.FindAll(number => number < 0);
            return InvalidNumbers.Count == 0;
        }
    }
}
