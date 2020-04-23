using System;
using Xunit;
using Moq;
namespace AuthenticationFW.Tests
{
    public class Authentication_Should
    {
        [Fact]
        public void ReturnTrue_SiLoginETMotDePasseSontBon()
        {
            string login = "login";
            string password = "password";
            Mock<IUserStore> userStore = new Mock<IUserStore>();
            Mock<IEncryption> encryption = new Mock<IEncryption>();
            userStore.Setup(o => o.Get(login))
                 .Returns(new User
                 {
                     Login = login,
                     Password = password
                 });
            encryption.Setup(o => o.Encrypt(It.Is<User>(user => user.Login == login && user.Password == password)))
                .Returns(password);
           
            var authentication = new Authentication(userStore.Object, encryption.Object);

            var result = authentication.Login(login, password);

            Assert.True(result);
        }

        [Fact]
        public void ReturnFalse_SiLoginEstIncorrect()
        {
            string login = "mauvaisLogin";
            string password = "password";
            Mock<IUserStore> userStore = new Mock<IUserStore>();
            Mock<IEncryption> encryption = new Mock<IEncryption>();

            userStore.Setup(o => o.Get(login))
                 .Returns((User) null);
            var authentication = new Authentication(userStore.Object, encryption.Object);

            var result = authentication.Login(login, password);

            Assert.False(result);
            encryption.Verify(o => o.Encrypt(It.IsAny<User>()), Times.Never);
        }

        [Fact]
        public void ReturnTrue_SiMotDePasseestIncorrect()
        {
            string login = "login";
            string password = "fakepassword";
            Mock<IUserStore> userStore = new Mock<IUserStore>();
            Mock<IEncryption> encryption = new Mock<IEncryption>();

            userStore.Setup(o => o.Get(login))
                 .Returns((User)null);
            encryption.Setup(o => o.Encrypt(It.Is<User>(user => user.Login == login && user.Password == password)))
                .Returns(password);

            var authentication = new Authentication(userStore.Object, encryption.Object);

            var result = authentication.Login(login, password);

            Assert.False(result);

        }
    }
}
