namespace UnitTest
{
    public class PasswordValidator : IPasswordValidator
    {
        public bool ValidatePassword(string password)
        {
            if(password.Length <= 8 ||  password.Length == 0) return false;

            if(!password.Any(x => char.IsUpper(x))) return false;

            return true;
        }
    }
}
