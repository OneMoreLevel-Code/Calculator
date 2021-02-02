using System;

namespace CalculatorNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Boolean isRunning = true;
            while (isRunning) 
            {
                Console.WriteLine("What type of calculation do you want to perform? (+, -, * or /");
                var typeOfCalculation = Console.ReadLine();

                var firstNumber = 0;
                var secondNumber = 0;

                try
                {
                    Console.WriteLine("Write the first number");
                    firstNumber = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Write the second number");
                    secondNumber = Int32.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Unable to parse input");
                }

                var answer = calculator.Calculate(typeOfCalculation, firstNumber, secondNumber);

                Console.WriteLine($"The answer is {answer}");
                
                Console.WriteLine("Write 'Yes' to restart the application");
                var restartAnswer = Console.ReadLine();

                if(!restartAnswer.Equals("Yes"))
                {
                    break;
                }
                
            }

        }
    }
}
