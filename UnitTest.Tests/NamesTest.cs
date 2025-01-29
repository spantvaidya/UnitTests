using Xunit;

namespace UnitTest.Tests
{
    public class NameFixture
    {
        public Names Names => new Names();
    }
    public class NamesTest : IClassFixture<NameFixture>
    {
        private readonly NameFixture _namesfixture;
        public NamesTest(NameFixture namesfixture)
        {
            _namesfixture = namesfixture;
        }
        //Asserting String Values
        [Fact]
        [Trait("Category", "Name")]
        public void MakeFUllNamesTest()
        {
            var names = _namesfixture.Names;
            var result = names.MakeFullNames("Sam", "Pant");
            //Assert.Equal("Sam Pant", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+",result);
        }

        //Asserting boolean values
        [Fact]
        [Trait("Category", "Name")]
        public void NickName_MustbeNull()
        {
            var names = _namesfixture.Names;
            var result = names.NickName;
            Assert.Null(result);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void NickName_NotNull()
        {
            var names = _namesfixture.Names;
            var result = names.NickName = "Sam";
            Assert.NotNull(result);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void NickName_AlwaysReturnsValue()
        {
            var names = _namesfixture.Names;
            var result = names.MakeFullNames("Sam", "Pantvaidya");
            Assert.NotNull(result);
            Assert.False(String.IsNullOrEmpty(result));
        }
    }
}
