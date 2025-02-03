using System.Reflection;
using Xunit.Sdk;

namespace UnitTest.Tests
{
    public class IsOddEvenData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1, true };
            yield return new object[] { 200, false };
        }
    }
}
