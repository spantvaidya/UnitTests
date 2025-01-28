namespace UnitTest
{
    public class Customer
    {
        public string Name => "Sameer";
        public int Age => 10;

        public int GetCusotmerByName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }
    }
}
