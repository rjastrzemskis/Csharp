using System;

namespace Exercise5
{
    public class Date
    {
        private int _myDay;
        private int _myMonth;
        private int _myYear;

        public Date(int day, int month, int year)
        {
            _myDay = day;
            _myMonth = month;
            _myYear = year;
        }

        public int setDay(int day)
        {
            _myDay = day;
            return _myDay;
        }

        public int setMonth(int month)
        {
            _myMonth = month;
            return _myMonth;
        }

        public int setYear(int year)
        {
            _myYear = year;
            return _myYear;
        }

        public string DisplayDate()
        {
            return "Day off in " + _myDay + "/" + _myMonth + "/" + _myYear;
        }
    }
}