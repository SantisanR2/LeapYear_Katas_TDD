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

    [Fact]
    public void Debe_Dar_False_Si_Es_Divisible_100_Pero_No_400()
    {
        //Arrange
        var year = 500;
        
        //Act
        var  isLeapYear = IsLeapYear(year);
        
        //Assert
        isLeapYear.Should().Be(false);
    }

    private bool IsLeapYear(int year)
    {
        bool isLeap = year % 4 == 0;
        
        if (year>=400 && year % 400 != 0)
            isLeap = false;
        
        return isLeap;
    }
}