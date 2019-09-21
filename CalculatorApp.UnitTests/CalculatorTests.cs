using CalculatorApp.Internal.Filters;
using CalculatorApp.Internal.Validators;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void Calculate_Should_Call_Filter()
        {
            var validator = Substitute.For<INumberValidator>();
            validator.IsValid(Arg.Any<List<int>>()).Returns(true);

            List<int> testNumbers = new List<int>() { 9000, 2, 25, 6600, 5, 1000 };
            var filter = Substitute.For<INumberFilter>();
            filter.Filter(Arg.Any<List<int>>()).Returns(testNumbers.FindAll(n => n <= 1000));

            Calculator calculator = new Calculator(validator, filter);
            calculator.Input = "Test";

            calculator.Calculate();

            filter.Received(1).Filter(Arg.Any<List<int>>());
        }
    }
}
