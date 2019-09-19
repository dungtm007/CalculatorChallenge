using CalculatorApp;
using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            char wantToRetry;

            do
            {
                Calculator calculator = new Calculator();
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
    }
}
