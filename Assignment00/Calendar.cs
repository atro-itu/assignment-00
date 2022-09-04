namespace Assignment00;

public class Calendar
{
  public bool IsLeapYear(int year)
  {
    if (year % 4 != 0) return false;
    if (year % 100 == 0 && year % 400 != 0) return false;

    return true;
  }
}
