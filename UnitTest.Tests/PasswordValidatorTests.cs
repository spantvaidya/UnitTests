using Xunit;

namespace UnitTest.Tests
{
    public class PasswordValidatorTests
    {
        [Fact]
        [Trait("Category","PasswdValidate")]
        public void Validate_PwdGreaterthan8Chars_ReturnTrue()
        {
            var passwordValidator = new PasswordValidator();
            string strPwd = MakeString(8) + "A";
            var validateResult = passwordValidator.ValidatePassword(strPwd);
            Assert.True(validateResult);
        }

        [Fact]
        [Trait("Category", "PasswdValidate")]
        public void Validate_PwdLessthan8Chars_ReturnFalse()
        {
            var passwordValidator = new PasswordValidator();
            string strPwd = MakeString(6) + "A";
            var validateResult = passwordValidator.ValidatePassword(strPwd);
            Assert.False(validateResult);
        }

        [Fact]
        [Trait("Category", "PasswdValidate")]
        public void Validate_PwdNoUppercaseChar_ReturnFalse()
        {
            var passwordValidator = new PasswordValidator();
            string strPwd = MakeString(8) + "c";
            var validateResult = passwordValidator.ValidatePassword(strPwd);
            Assert.False(validateResult);
        }

        [Fact]
        [Trait("Category", "PasswdValidate")]
        public void Validate_PwdOneUppercaseChar_ReturnTrue()
        {
            var passwordValidator = new PasswordValidator();
            string strPwd = MakeString(8) + "C";
            var validateResult = passwordValidator.ValidatePassword(strPwd);
            Assert.True(validateResult);
        }

        public string MakeString(int count)
        {
            string pwd = string.Empty;
            for(int i =0; i <= count; i++)
            {
                pwd += "a";
            }

            return pwd;
        }
    }
}
