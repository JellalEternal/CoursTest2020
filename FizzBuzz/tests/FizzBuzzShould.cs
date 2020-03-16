using System;
using Xunit;
using FizzBuzzImpl;

namespace FizzBuzzImpl.Tests
{
    public class FizzBuzzClass_FizzBuzzShould
    {
        private FizzBuzzClass fizzBuzzClass;
        public FizzBuzzClass_FizzBuzzShould()
        {
            
            fizzBuzzClass = new FizzBuzzClass();
        }
        
        [Fact]
        public void Return2_WhenEnter2(){
            //Arrange
            int value = 2;
            string expected = "2";
            

            //Act
            string result = fizzBuzzClass.FizzBuzz(value);

            //Assert
            Assert.Equal(expected,result);
        }


        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ReturnFizz_WhenEnter3(int value)
        {
            //Arrange
            string expected = "Fizz";

            //Act
            string result = fizzBuzzClass.FizzBuzz(value);

            //Assert
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void ReturnBuzz_WhenEnter5()
        {
            //Arrange
            int value = 5;
            string expected = "Buzz";

            //Act
            string result = fizzBuzzClass.FizzBuzz(value);

            //Assert
            Assert.Equal(expected,result);
        }
        
        [Fact]
        public void ReturnFizzBuzz_WhenEnter15()
        {
            //Arrange
            int value =15;
            string expected = "FizzBuzz";

            //Act
            string result = fizzBuzzClass.FizzBuzz(value);

            //Assert
            Assert.Equal(expected,result);
        }
    }
}
