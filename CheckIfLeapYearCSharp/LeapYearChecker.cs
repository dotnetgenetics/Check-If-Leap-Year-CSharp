namespace CheckIfLeapYearCSharp
{
    public class LeapYearChecker
    {
        public bool CheckLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;

            return false;
        }

        public bool CheckLeapYearBuiltIn(int year)
        {
            if (DateTime.IsLeapYear(year))
                return true;

            return false;
        }
    }
}