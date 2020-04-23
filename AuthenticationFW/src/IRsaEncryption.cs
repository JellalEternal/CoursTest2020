namespace AuthenticationFW
{
    public interface IEncryption
    {
        string Encrypt(string password);
        string Encrypt(User user);
    }
}