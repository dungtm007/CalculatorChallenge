using CalculatorApp.Internal.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorApp.UnitTests.Internal.Validators
{
    public class PositiveNumberValidatorTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void IsValid_Should_Return_False_If_Any_Negative(List<int> numbers, bool expectedResult)
        {
            var positiveNumberValidator = new PositiveNumberValidator();
            var result = positiveNumberValidator.IsValid(numbers);
            Assert.Equal(result, expectedResult);
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { new List<int>() { 23, 17, 90 }, true  },
                new object[] { new List<int>() { -7, 30, 40, 50 }, false  },
                new object[] { new List<int>() { 5, 0, 0, 100 }, true },
                new object[] { new List<int>() { 29, 6, 18, 45, -9, 63 }, false },
                new object[] { new List<int>() { -2, 5, -8, -13, -40, 55 }, false },
                new object[] { new List<int>() { int.MinValue, -1, int.MaxValue }, false },
            };

    }
}
