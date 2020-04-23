namespace AuthenticationFW
{
    public class Authentication
    {
        readonly IUserStore userStore;
        readonly IEncryption encryption;

        public Authentication(IUserStore userStore, IEncryption encryption)
        {
            this.userStore = userStore;
            this.encryption = encryption;
        }

        public Authentication()
        {
            userStore = new UserStore();
            encryption = new Md5Encryption();
        }

        public bool Login(string login, string password)
        {   
            User myUser = userStore.Get(login);
            if (myUser == null)
            {
                return false;
            }
            if (myUser.Password == encryption.Encrypt(myUser))
            {
                return true;
            }
            return false;
        }
    }
}