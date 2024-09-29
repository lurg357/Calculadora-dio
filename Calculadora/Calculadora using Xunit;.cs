using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ReturnsSum_WhenCalledWithTwoIntegers()
        {
            var result = _calculator.Add(3, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsDifference_WhenCalledWithTwoIntegers()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ReturnsProduct_WhenCalledWithTwoIntegers()
        {
            var result = _calculator.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_ReturnsQuotient_WhenCalledWithTwoIntegers()
        {
            var result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ThrowsDivideByZeroException_WhenDividedByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
