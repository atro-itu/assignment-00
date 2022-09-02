namespace Assignment00;

public class Calendar
{
  public bool IsLeapYear(int year)
  {
    if (year % 4 == 0) return true;

    return false;
  }
}
