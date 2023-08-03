using NuGet.Frameworks;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(9, 14, 8, 31)] 
        [InlineData(17, 4, 2, 23)] 
        [InlineData(5, 8, 7, 20)] 
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator adding = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var addition = adding.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, addition);
        }

        [Theory]
        [InlineData(12, 7, 5)]
        [InlineData(31, 12, 19)]
        [InlineData(4, 8, -4)]
        [InlineData(-1, -2, 1)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator subtraction = new Calculator();
            //Act
            var sub1 = subtraction.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, sub1);
        }

        [Theory]
        [InlineData(7, 5, 35)]
        [InlineData(8, 4, 32)]
        [InlineData(2, 5, 10)]
        [InlineData(25, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiply = new Calculator();
            //Act
            var mult1 = multiply.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, mult1);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(27, 3, 9)]
        [InlineData(10, 0, 0)]
        [InlineData(0, 0, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divider = new Calculator();
            //Act
            var div1 = divider.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, div1);
        }

    }
}
