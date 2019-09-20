using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp.Internal.Validators
{
    public interface INumberValidator
    {
        string ViolatedConditionName { get; }
        List<int> InvalidNumbers { get; }
        bool IsValid(List<int> numbers);
    }
}
