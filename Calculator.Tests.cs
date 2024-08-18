using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator; 
        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Additional_PositiveNumbers_ReturnsCorrectResult()
        {
            //Arrange
            int a = 5;
            int b = 10;
            int expectedResult = 15;

            //Act
            int result = _calculator.Additional(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Additional_NegativeNumbers_ReturnsCorrectResult()
        {
            //Arrange
            int a = -5;
            int b = -10;
            int expectedResult = -15;

            //Act
            int result = _calculator.Additional(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtraction_NegativeResult_ReturnsCorrectResult()
        {
            //Arrange
            int a = 2; 
            int b = 3;
            int expectedResult = -1;

            //Act
            int result = _calculator.Subtraction(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtraction_PositiveNumbers_ReturnsCorrectResult()
        {
            //Arrange
            int a = 15;
            int b = 5;
            int expectedResult = 10;

            //Act
            int result = _calculator.Subtraction(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Division_PositiveNumbers_ReturnsCorrectResult()
        {
            //Arrange
            int a = 15;
            int b = 5;
            int expectedResult = 3;

            //Act
            int result = _calculator.Division(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Division_WithZeroNumber_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 15;
            int b = 0;
            Exception exception = null;

            // Act
            try
            {
                _calculator.Division(a, b);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            // Assert
            Assert.IsType<DivideByZeroException>(exception);
        }
        //[TestFixture]
        //public class CalculatorTests
        //{
        //    [Test]
        //    public void Division_MustThrowException()
        //    {
        //        var calculator = new Calculator();
        //        Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        //    }
        //}

        [Fact]
        public void Division_NegativeNumbers_ReturnsCorrectResult()
        {
            //Arrange
            int a = -2;
            int b = -1;
            int expectedResult = 2;

            //Act
            int result = _calculator.Division(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Miltiplication_NegativeNumbers_ReturnsCorrectResult()
        {
            //Arrange
            int a = -2;
            int b = -4;
            int expectedResult = 8;

            //Act
            int result = _calculator.Multiplication(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Miltiplication_PositiveNumbers_ReturnsCorrectResult()
        {
            //Arrange
            int a = 2;
            int b = 4;
            int expectedResult = 8;

            //Act
            int result = _calculator.Multiplication(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Miltiplication_NumbersWithDifferentSigns_ReturnsCorrectResult()
        {
            //Arrange
            int a = -3;
            int b = 4;
            int expectedResult = -12;

            //Act
            int result = _calculator.Multiplication(a, b);

            //Assert
            Assert.Equal(expectedResult, result); 
        }
    }
}