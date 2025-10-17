using AwesomeAssertions;

namespace LeapYear;

public class LeapYearTest
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var year = 16;

        //Act
        var isLeapYear = IsLeapYear(year);

        //Assert
        isLeapYear.Should().Be(true);

    }

    private bool IsLeapYear(int year)
    {
        throw new NotImplementedException();
    }
}