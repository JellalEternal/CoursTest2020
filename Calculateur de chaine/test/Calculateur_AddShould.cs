using System;
using Xunit;

namespace CalculateurChaine.Tests
{
    public class Calculateur_AddShould
    {
        private Calculateur calculateur;
        public Calculateur_AddShould(){
            this.calculateur = new Calculateur();
        }

        [Fact]
        public void Return0_WhenStringEmpty()
        {
            //Arrange
            string value = string.Empty;
            int expected = 0;

            //Act
            int result = calculateur.Add(value);

            //Assert
            Assert.Equal(expected,result);
        }


        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("125", 125)]
        [InlineData("135", 135)]
        public void ReturnSameNumber_WhenSendOneNumber(string value, int expected)
        {
            //Arrange

            //Act
            int result = calculateur.Add(value);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,5", 7)]
        [InlineData("125,143", 268)]
        [InlineData("135,1", 136)]
        public void 
            ReturnAddition_WhenSendTwoNumber(string value, int expected)
        {
            //Arrange

            //Act
            int result = calculateur.Add(value);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("1,2,3,4", 10)]
        [InlineData("125,143,1", 269)]
        [InlineData("1,2,3,4,5,6,7", 28)]
        public void ReturnAddition_WhenSendMultipleNumber(string value, int expected)
        {
            //Arrange

            //Act
            int result = calculateur.Add(value);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,2\n3", 6)]
        [InlineData("1,2,3\n4", 10)]
        [InlineData("125\n143,1", 269)]
        [InlineData("1,2,3,4\n5,6,7", 28)]
        public void ReturnAddition_WhenSendMultipleNumberWithNewLineSeparator(string value, int expected)
        {
            //Arrange

            //Act
            int result = calculateur.Add(value);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
