using System;

namespace CalculatorNS
{
    public class Calculator
    {
        public int Calculate(string typeOfCalculation, int firstNumber, int secondNumber)
        {
            var answer = 0;

            if(typeOfCalculation.Equals("+"))
            {
                answer = Add(firstNumber, secondNumber);
            } 
            else if (typeOfCalculation.Equals("-"))
            {
                answer = Subtract(firstNumber, secondNumber);
            }
            else if (typeOfCalculation.Equals("*"))
            {
                answer = Multiply(firstNumber, secondNumber);
            }
            else
            {
                answer = Divide(firstNumber, secondNumber);
            }

            return answer;
        }

        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
