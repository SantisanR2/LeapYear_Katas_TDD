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
    public void test()
    {
        //Arrange
        var year = 21;
        
        //Act
        var isLeapYear = IsLeapYear(year);
        
        //Assert
        isLeapYear.Should().Be(false);
    }

    private bool IsLeapYear(int year)
    {
        return true;
    }
}