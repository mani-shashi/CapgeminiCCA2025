using System;

namespace PracticeQuestions
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            return year % 400 == 0;
        }
    }
}