namespace UnitTest
{
    public class Customer
    {
        public string Name => "Sameer";
        public int Age => 10;

        public virtual int GetCustomerByName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }
    }

    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }
        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetCustomerByName(string Name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if(orderCount > 100) return new LoyalCustomer();
            
            return new Customer();
        }
    }
}
