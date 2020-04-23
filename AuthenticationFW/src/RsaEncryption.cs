namespace AuthenticationFW
{
    public class RsaEncryption : IEncryption
    {
        public string Encrypt(string password)
        {
            return password;
        }

        public string Encrypt(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}