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

            char wantToRetry;

            do
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

                Console.Write("Want to retry (n/N to stop; anything to continue)? ");
                wantToRetry = Console.ReadKey().KeyChar;
            }
            while (!wantToRetry.Equals('n') && !wantToRetry.Equals('N'));

            Console.WriteLine();
            Console.WriteLine("Exiting the program...");
            Console.ReadKey();
        }
    }
}
