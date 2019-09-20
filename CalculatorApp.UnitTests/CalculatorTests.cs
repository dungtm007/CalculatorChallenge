using CalculatorApp.Internal.Filters;
using CalculatorApp.Internal.Validators;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorApp.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculate_If_Input_Numbers_Violate_Should_Throw_Exception()
        {
            var validator = Substitute.For<INumberValidator>();
            validator.IsValid(Arg.Any<List<int>>()).Returns(false);
            validator.ViolatedConditionName.Returns("Negative Number");
            List<int> testNumbers = new List<int>() { 9, -2, 25, -66, -14 };
            validator.InvalidNumbers.Returns(testNumbers.FindAll(n => n < 0));

            var filter = Substitute.For<INumberFilter>();

            Calculator calculator = new Calculator(validator, filter);
            calculator.Input = "Test";

            var exception = Record.Exception(() => calculator.Calculate());

            Assert.NotNull(exception);
            Assert.True(exception is ArgumentException);
            var excpectedMsg = "Negative Number: -2,-66,-14";
            Assert.Equal(exception.Message, excpectedMsg);
        }
    }
}
