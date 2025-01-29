using Xunit;

namespace UnitTest.Tests
{
    public class CalculatorFixture //Fixture Class to Reuse Calc class
    {
        public Calculator Calc => new Calculator();
    }
    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorfixture;

        public CalculatorTest(CalculatorFixture calculatorfixture)
        {
            _calculatorfixture = calculatorfixture;
        }
        //Asserting Numeric Values
        [Fact]
        public void TestAdd_ReturnsInt()
        {
            Calculator calculator = _calculatorfixture.Calc;
            var result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestAddDouble_ReturnsDouble()
        {
            Calculator calculator = _calculatorfixture.Calc;
            var result = calculator.AddDouble(1.4, 2.8);
            Assert.Equal(4.2, result, 1);
        }

        [Fact]
        [Trait("Category","Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            Calculator calculator = _calculatorfixture.Calc;
            Assert.All(calculator.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            Calculator calculator = _calculatorfixture.Calc;
            Assert.Contains(13,calculator.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            Calculator calculator = _calculatorfixture.Calc;
            Assert.DoesNotContain(4, calculator.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            List<int> list = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            Calculator calculations = _calculatorfixture.Calc;
            Assert.Equal(list,calculations.FiboNumbers);
        }
    }
}
