using System.Collections.Generic;

namespace CalculatorApp.Internal.Filters
{
    public interface INumberFilter
    {
        List<int> Filter(List<int> numbers);
    }
}
