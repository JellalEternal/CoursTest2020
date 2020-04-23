namespace AuthenticationFW
{
    public class UserStore : IUserStore
    {
        public User Get(string login)
        {
            return new User()
            {
                Login = login,
                Password = "password"
            };
        }
    }
}