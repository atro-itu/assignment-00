namespace Assignment00;

public class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Enter a year: ");
    string? input = Console.ReadLine();
    input ??= "-1";
    var year = int.Parse(input);

    Calendar calendar = new Calendar();
    bool isLeapYear = calendar.IsLeapYear(year);

    string output = isLeapYear ? "yay" : "nay";
    Console.WriteLine(output);
  }
}
