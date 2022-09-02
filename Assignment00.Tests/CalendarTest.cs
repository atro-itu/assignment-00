namespace Assignment00.Tests;

public class CalendarTest
{
  [Fact]
  public void IsLeapYear_when_given_2004_returns_true()
  {
    // Arrange
    Calendar calendar = new Calendar();

    // Act
    var result = calendar.IsLeapYear(2004);

    // Assert
    result.Should().Be(true);
  }
}
