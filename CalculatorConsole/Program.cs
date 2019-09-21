using CalculatorApp;
using CalculatorApp.Internal.Filters;
using CalculatorApp.Internal.Validators;
using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new PositiveNumberValidator(), new LessThanOrEqual1000NumberFilter());
            while (true)
            {
                try
                {
                    calculator.ReadInput();
                    calculator.Calculate();
                    calculator.DisplayResult();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }
    }
}
