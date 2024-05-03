
namespace UsersHub.Users
{
    public class User
    {
        private string _name;
        private string _secondName;
        private string _email;

        public User(string name, string secondName, string email)
        {
            _name = name;
            _secondName = secondName;
            _email = email;
        }

        public override int GetHashCode()
        {
            return _email.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is User user)
            {
                return user._email == _email;
            }

            return false;
        }
    }
}
