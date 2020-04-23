namespace AuthenticationFW
{
    public interface IUserStore
    {
        User Get(string login);
    }
}