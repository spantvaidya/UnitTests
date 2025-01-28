using Xunit;

namespace UnitTest.Tests
{
    public class CustomerTest
    {
        //Asserting Exception
        [Fact]
        public void GetCusotmerByNameNotNull()
        {
            var customer = new Customer();
            var exceptiondetails = Assert.Throws<ArgumentException>(
                () => customer.GetCusotmerByName(""));
            Assert.Equal("Hello", exceptiondetails.Message);
        }
    }
}
