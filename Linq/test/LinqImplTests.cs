using System;
using Xunit;

namespace LinqImpl.Tests
{
    public class LinqImplTests
    {
        [Fact]
        public void FctQuiRetourneLesMotsOrdonnesContenantUnCaractere()
        {
            LinqImpl linqImpl = new LinqImpl();
            var expected = new[] {"armoire", "avion", "chaine", "chat", "étagère", "maison", "train"};
            
            var resultat = linqImpl.Contient('a');

            Assert.Equal(expected, resultat);
        }
    }
}
