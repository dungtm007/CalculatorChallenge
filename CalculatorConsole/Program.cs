using CalculatorApp;
using CalculatorApp.Validators;
using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            char wantToRetry;

            try
            {
                do
                {
                    Calculator calculator = new Calculator(new PositiveNumberValidator());
                    calculator.ReadInput();
                    calculator.Calculate();

                    Console.Write("Want to retry (n/N to stop; anything to continue)? ");
                    wantToRetry = Console.ReadKey().KeyChar;
                }
                while (!wantToRetry.Equals('n') && !wantToRetry.Equals('N'));

                Console.WriteLine();
                Console.WriteLine("Exiting the program...");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
