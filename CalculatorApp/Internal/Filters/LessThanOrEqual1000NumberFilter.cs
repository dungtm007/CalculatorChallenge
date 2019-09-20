using System.Collections.Generic;

namespace CalculatorApp.Internal.Filters
{
    public class LessThanOrEqual1000NumberFilter : INumberFilter
    {
        public List<int> Filter(List<int> numbers)
        {
            return numbers.FindAll(number => number <= 1000);
        }
    }
}
