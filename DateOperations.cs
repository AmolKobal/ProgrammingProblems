using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblems.Test
{
    class DateOperations
    {

        /*
         * Write a program which will acctept a date in either long hand or short hand (eg. either 8/11/2019 or 8th November, 2019 ) 
         * and work out if the given date is valid. eg. 14/13/2019 is clearly not valid.
         */

        public static bool ValidDate(string input)
        {
            bool inValid = false;

            if (input.Contains("/"))
            {
                string[] dateParts = input.Split('/');

                if (dateParts.Length != 2)
                    return false;

                int day, month, year;

                try
                {
                    day = Convert.ToInt32(dateParts[0]);
                    month = Convert.ToInt32(dateParts[1]);
                    year = Convert.ToInt32(dateParts[2]);
                }
                catch
                {
                    return inValid;
                }

                if (year <= 0)
                    return inValid;

                return IsValidDate(day, month, year);
            }
            else
            {
                string[] dateParts = input.Split(' ');
                if (dateParts.Length != 2)
                    return false;

                if (dateParts.Length != 2)
                    return false;

                string day, month;
                int year;

                try
                {
                    day = dateParts[0].Replace(",", "");
                    month = dateParts[1].Replace(",", "");
                    year = Convert.ToInt32(dateParts[2]);
                }
                catch
                {
                    return inValid;
                }

                if (year <= 0)
                    return inValid;

                day = day.Replace("ST", "").Replace("ND", "").Replace("RD", "").Replace("TH", "");
                int day_num = 0;

                try
                {
                    day_num = Convert.ToInt32(day);
                }
                catch
                {
                    return inValid;
                }

                int month_num = 0;
                switch (month.ToUpper())
                {
                    case "JANUARY":
                        month_num = 1;
                        break;
                    case "FEBRUARY":
                        month_num = 2;
                        break;
                    case "MARCH":
                        month_num = 3;
                        break;
                    case "APRIL":
                        month_num = 4;
                        break;
                    case "MAY":
                        month_num = 5;
                        break;
                    case "JUNE":
                        month_num = 6;
                        break;
                    case "JULY":
                        month_num = 7;
                        break;
                    case "AUGUST":
                        month_num = 8;
                        break;
                    case "SEPTEMBER":
                        month_num = 9;
                        break;
                    case "OCTOBER":
                        month_num = 10;
                        break;
                    case "NOVEMBER":
                        month_num = 11;
                        break;
                    case "DECEMBER":
                        month_num = 12;
                        break;
                    default:
                        return inValid;
                }

                return IsValidDate(day_num, month_num, year);
            }

            return true;
        }

        private static bool IsValidDate(int day, int month, int year)
        {
            bool inValid = false;

            if (day <= 0 || day > 31)
                return inValid;
            if (month <= 0 || day > 12)
                return inValid;

            if (year % 4 == 0) // Leap Year
            {
                if (month == 2 && day > 29)
                    inValid = false;
            }
            else
            {
                switch (month)
                {
                    case 3:
                    case 6:
                    case 9:
                    case 11:
                        if (month > 30)
                            return inValid;
                        break;
                    default:
                        break;
                }
            }

            return true;
        }


        /*
         * Time is often recorded within computers as something called a timestamp.Write a program which will accept two 
         * timestamps and tell you the difference between them in human readable form.eg:
         *
         * Enter timestamps: 1573231345 1573236625	=> 1 hour 28 minutes
         */
        public static string TimestampDifference(long timestamp1, long timestamp2)
        {
            string output = "";

            return output;
        }

    }
}
