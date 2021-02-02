using System;
using Xunit;

namespace CalculatorNS.test
{
    public class CalculatorTests
    {
        [Fact]
        public void Addition()
        {
            Calculator calculator = new Calculator();
            var typeOfCalculation = "+";
            var x = 5;
            var y = 4;

            var answer = calculator.Calculate(typeOfCalculation, x, y);

            Assert.Equal(9, answer);
        }
        [Fact]
        public void Subtraction()
        {
            Calculator calculator = new Calculator();
            var typeOfCalculation = "-";
            var x = 5;
            var y = 4;

            var answer = calculator.Calculate(typeOfCalculation, x, y);

            Assert.Equal(1, answer);
        }
        [Fact]
        public void Multiplication()
        {
            Calculator calculator = new Calculator();
            var typeOfCalculation = "*";
            var x = 5;
            var y = 4;

            var answer = calculator.Calculate(typeOfCalculation, x, y);

            Assert.Equal(20, answer);
        }
        [Fact]
        public void Division()
        {
            Calculator calculator = new Calculator();
            var typeOfCalculation = "/";
            var x = 4;
            var y = 2;

            var answer = calculator.Calculate(typeOfCalculation, x, y);

            Assert.Equal(2, answer);
        }
    }
}
