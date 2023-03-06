
using Xunit;
using SquareChecker;
namespace SquareChecker.Tests
{
    
    public class CheckerTests
    {
        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(25, true)]
        [InlineData(26, false)]
        public void Check_IFReturnValue_IsTrueOrFalse(int number, bool expected)
        {
            //Arrange
            var sut = new Checker();
            //Act
            var result = sut.Check(number);
            //Assert
            Assert.Equal(expected, result);
        }

    }
}
