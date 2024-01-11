using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_hw
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;
        private static int[] monthsWith31Days = { 1, 5, 7, 8, 10, 12 };

        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public int Day
        {
            get { return day; }
            set
            {
                if ((value > 0 && value <= 28) ||
                    (value > 0 && value <= 30 && month != 2) ||
                    (value == 31 && monthsWith31Days.Contains(month)) ||
                    (value == 29 && month == 2 && year % 4 == 0))
                {
                    day = value;
                }
                else
                {
                    throw new FormatException("Attempting to assign a value to a day that does not exist in this month");
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    if ((day <= 28) ||
                        day <= 30 && value != 2 ||
                        day == 31 && monthsWith31Days.Contains(value) ||
                        day == 29 && value == 2 && year % 4 == 0)
                    {
                        month = value;
                    }
                    else
                    {
                        throw new FormatException("Attempting to assign a value to a month that cannot have this number of days");
                    }
                }
                else
                {
                    throw new FormatException("Attempting to assign a value outside the range of possible months");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (month == 2 && day == 29 && value % 4 != 0)
                {
                    throw new FormatException("A non-leap year cannot have 29 days in February");
                }
                else
                {
                    year = value;
                }
            }
        }

        public static int operator -(Date date1, Date date2)
        {
            int daysInMonth = 30; //simplified version (average number of days in a month)
            int difference = (date1.year - date2.year) * 365 + (date1.month - date2.month) * daysInMonth + (date1.day - date2.day);
            return difference;
        }
        public static Date operator +(Date date, int days)
        {
            int daysInMonth = 30; //simplified version (average number of days in a month)
            int totalDays = date.day + days;
            int newDay = totalDays % daysInMonth;
            int monthsToAdd = totalDays / daysInMonth;
            int newMonth = (date.month + monthsToAdd) % 12;
            int newYear = date.year + (date.month + monthsToAdd) / 12;

            return new Date(newDay, newMonth, newYear);
        }

    }
}
