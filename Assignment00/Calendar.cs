namespace Assignment00;

public class Calendar
{
  public bool IsLeapYear(int year)
  {
    if (year < 1582) throw new ArgumentException("Invalid year. Must be 1582 or greater.");
    if (year % 4 != 0) return false;
    if (year % 100 == 0 && year % 400 != 0) return false;

    return true;
  }
}
