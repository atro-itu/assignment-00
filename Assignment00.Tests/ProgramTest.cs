namespace Assignment00.Tests;

public class ProgramTest
{
  [Fact]
  public void Main_when_given_leap_year_prints_yay()
  {
    // Arrange
    using (var mockOutput = new StringWriter())
    {
      using (var mockInput = new StringReader("2004"))
      {
        Console.SetOut(mockOutput);
        Console.SetIn(mockInput);

        // Act
        var program = Assembly.Load(nameof(Assignment00));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var result = mockOutput.ToString();
        result.Should().Contain("yay");
      }
    }
  }

  [Fact]
  public void Main_when_given_non_leap_year_prints_nay()
  {
    // Arrange
    using (var mockOutput = new StringWriter())
    {
      using (var mockInput = new StringReader("1800"))
      {
        Console.SetOut(mockOutput);
        Console.SetIn(mockInput);

        // Act
        var program = Assembly.Load(nameof(Assignment00));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var result = mockOutput.ToString();
        result.Should().Contain("nay");
      }
    }
  }
}
