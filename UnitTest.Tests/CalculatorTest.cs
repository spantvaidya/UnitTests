using Xunit;

namespace UnitTest.Tests
{
    public class CalculatorTest
    {
        //Asserting Numeric Values
        [Fact]
        public void TestAdd_ReturnsInt()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestAddDouble_ReturnsDouble()
        {
            Calculator calculator = new Calculator();
            var result = calculator.AddDouble(1.4, 2.8);
            Assert.Equal(4.2, result, 1);
        }

        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            Calculator calculator = new Calculator();
            Assert.All(calculator.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboIncludes13()
        {
            Calculator calculator = new Calculator();
            Assert.Contains(13,calculator.FiboNumbers);
        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            Calculator calculator = new Calculator();
            Assert.DoesNotContain(4, calculator.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            List<int> list = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            Calculator calculations = new Calculator();
            Assert.Equal(list,calculations.FiboNumbers);
        }
    }
}
