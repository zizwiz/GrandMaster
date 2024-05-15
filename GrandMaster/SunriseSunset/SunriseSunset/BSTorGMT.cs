using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseSunset
{
    class CheckDate
    {
        public static string LastSundayOfMonth(string month, string year)
        {
            //bool result = false;

            //int myYear = Convert.ToInt32(year);
            //int myMonth = Convert.ToInt32(month);

            //DateTime date;
            //for (int i = 1; i <= 12; i++)
            //{
            //    date = new DateTime(myYear, myMonth, DateTime.DaysInMonth(myYear, myMonth), System.Globalization.CultureInfo.CurrentCulture.Calendar);
            //    /* Modification by Albert Zakhia on 2021-16-02
            //       The below code is very slow due to the loop, we will go twice as fast
            //    while (date.DayOfWeek != DayOfWeek.Sunday)
            //    {
            //        date = date.AddDays(-1);
            //    }
            //    */
            //    // The updated code
            //    int daysOffset = date.DayOfWeek - dayOfWeek; // take the offset to subtract directly instead of looping
            //    if (daysOffset < 0) daysOffset += 7; // if the code is negative, we need to normalize them
            //    date = date.AddDays(-daysOffset); // now just add the days offset
            //    Console.WriteLine(date.ToString("yyyy-MM-dd"));
            //}

            int myyear = Convert.ToInt32(year);
            int mymonth = Convert.ToInt32(month);
            var myDayOfWeek = DayOfWeek.Sunday;

            DateTime date;
            string answer = "";
            
            date = new DateTime(myyear, mymonth, DateTime.DaysInMonth(myyear, mymonth), System.Globalization.CultureInfo.CurrentCulture.Calendar);

            int daysOffset = date.DayOfWeek - myDayOfWeek;
            if (daysOffset < 0) daysOffset += 7; // if the code is negative, we need to normalize them

            answer = date.AddDays(-daysOffset).ToLongDateString();
            
            return answer;
        }




    }
}
