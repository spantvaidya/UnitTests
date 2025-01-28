using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest.Tests
{
    public class NamesTest
    {
        //Asserting String Values
        [Fact]
        [Trait("Category", "Name")]
        public void MakeFUllNamesTest()
        {
            var names = new Names();
            var result = names.MakeFullNames("Sam", "Pant");
            //Assert.Equal("Sam Pant", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+",result);
        }

        //Asserting boolean values
        [Fact]
        [Trait("Category", "Name")]
        public void NickName_MustbeNull()
        {
            var names = new Names();
            var result = names.NickName;
            Assert.Null(result);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void NickName_NotNull()
        {
            var names = new Names();
            var result = names.NickName = "Sam";
            Assert.NotNull(result);
        }

        [Fact]
        [Trait("Category", "Name")]
        public void NickName_AlwaysReturnsValue()
        {
            var names = new Names();
            var result = names.MakeFullNames("Sam", "Pantvaidya");
            Assert.NotNull(result);
            Assert.False(String.IsNullOrEmpty(result));
        }
    }
}
