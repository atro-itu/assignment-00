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

  [Fact]
  public void IsLeapYear_when_given_1800_returns_false()
  {
    Calendar calendar = new Calendar();

    var result = calendar.IsLeapYear(1800);

    result.Should().Be(false);
  }

  [Fact]
  public void IsLeapYear_when_given_1700_returns_false()
  {
    Calendar calendar = new Calendar();

    var result = calendar.IsLeapYear(1700);

    result.Should().Be(false);
  }

  [Fact]
  public void IsLeapYear_when_given_1600_returns_true()
  {
    Calendar calendar = new Calendar();

    var result = calendar.IsLeapYear(1600);

    result.Should().Be(true);
  }

  [Fact]
  public void IsLeapYear_when_given_2000_returns_true()
  {
    Calendar calendar = new Calendar();

    var result = calendar.IsLeapYear(2000);

    result.Should().Be(true);
  }
}
