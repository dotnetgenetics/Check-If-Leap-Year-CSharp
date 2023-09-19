using CheckIfLeapYearCSharp;

namespace CheckIfLeapYearCSharpTest
{
    public class LeapYearTest
    {
        private readonly LeapYearChecker sut;

        public LeapYearTest()
        {
            sut = new LeapYearChecker();
        }

        [Fact]
        public void ShouldValidateIsLeapYearValue()
        {
            //Arrange
            int year = 2020;
            bool isLeapYear;

            //Act 
            isLeapYear = sut.CheckLeapYear(year);

            //Assert
            Assert.True(isLeapYear);
        }

        [Fact]
        public void ShouldValidateIsNotLeapYearValue()
        {
            //Arrange
            int year = 2022;
            bool isLeapYear;

            //Act 
            isLeapYear = sut.CheckLeapYear(year);

            //Assert
            Assert.False(isLeapYear);
        }

        [Fact]
        public void ShouldValidateIsLeapYearValueBuiltIn()
        {
            //Arrange
            int year = 2020;
            bool isLeapYear;

            //Act 
            isLeapYear = sut.CheckLeapYearBuiltIn(year);

            //Assert
            Assert.True(isLeapYear);
        }

        [Fact]
        public void ShouldValidateIsNotLeapYearValueBuiltIn()
        {
            //Arrange
            int year = 2022;
            bool isLeapYear;

            //Act 
            isLeapYear = sut.CheckLeapYearBuiltIn(year);

            //Assert
            Assert.False(isLeapYear);
        }
    }
}