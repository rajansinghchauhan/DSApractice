using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class TimeConversion
    {
        public string timeConversion(string s)
        {
            string[] arr = s.Split(':');
            string hours = arr[0];
            string minutes = arr[1];
            string secondsWithMeridian = arr[2];

            string meridian = secondsWithMeridian.Substring(secondsWithMeridian.Length - 2); // AM or PM
            string seconds = secondsWithMeridian.Substring(0, secondsWithMeridian.Length - 2);

            int hour = Convert.ToInt32(hours);

            if (meridian == "AM")
            {
                if (hour == 12) hour = 0; // midnight case
            }
            else if (meridian == "PM")
            {
                if (hour != 12) hour += 12; // afternoon/evening case
            }

            string hoursInMilitaryTime = hour.ToString("D2"); // pad with leading zero if needed

            return $"{hoursInMilitaryTime}:{minutes}:{seconds}";
        }
    }
}
