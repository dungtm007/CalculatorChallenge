using System.Linq;
using Xunit;

namespace CalculatorApp.Internal.Filters
{
    public class LessThanOrEqual1000NumberFilterTests
    {
        [Theory]
        [InlineData(6, 1000, 2, 45, 1002)]
        [InlineData(6, 100, 2, 45, 102)]
        [InlineData(10, 40, 5, 6, 2888, 999999)]
        [InlineData(7777777, 999999)]
        public void Filter_Should_Remove_Numbers_Greater_Than_1000(params int[] numbers)
        {
            LessThanOrEqual1000NumberFilter filter = new LessThanOrEqual1000NumberFilter();
            var lessThanOrEqual1000Numbers = filter.Filter(numbers.ToList());
            Assert.True(lessThanOrEqual1000Numbers.All(n => n <= 1000));
        }
    }
}
