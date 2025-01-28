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
                () => customer.GetCustomerByName(""));
            Assert.Equal("Hello", exceptiondetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrderGreater100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(101);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
