namespace UnitTest
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public double AddDouble(double x, double y)
        {
            return x + y;
        }

        public List<int> FiboNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };
    }
}
