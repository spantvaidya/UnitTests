using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd_ReturnsInt()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.Equal(3,result);
        }

        [Fact]
        public void TestAddDouble_ReturnsDouble()
        {
            Calculator calculator = new Calculator();
            var result = calculator.AddDouble(1.4, 2.8);
            Assert.Equal(4.2, result,1);
        }
    }
}
