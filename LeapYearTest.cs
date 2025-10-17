using AwesomeAssertions;

namespace LeapYear;

public class LeapYearTest
{
    [Fact]
    public void Debe_Dar_True_Si_Es_Divisible_4()
    {
        //Arrange
        var year = 16;

        //Act
        var isLeapYear = IsLeapYear(year);

        //Assert
        isLeapYear.Should().Be(true);

    }

    [Fact]
    public void Debe_Dar_False_Si_No_Es_Divisible_4()
    {
        //Arrange
        var year = 21;
        
        //Act
        var isLeapYear = IsLeapYear(year);
        
        //Assert
        isLeapYear.Should().Be(false);
    }

    [Theory]
    [InlineData(500)]
    [InlineData(300)]
    public void Debe_Dar_False_Si_Es_Divisible_100_Pero_No_400(int year)
    {
        //Arrange
        
        //Act
        var  isLeapYear = IsLeapYear(year);
        
        //Assert
        isLeapYear.Should().Be(false);
    }

    private bool IsLeapYear(int year)
    {
        if (year % 100 == 0 && year % 400 != 0)
            return false;
        
        return year % 4 == 0;
    }
}