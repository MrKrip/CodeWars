using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 359999)
            {
                seconds = 359999;
            }
            int Hours = seconds / 3600;
            int Minutes = (seconds % 3600) / 60;
            int Seconds = (seconds % 3600) % 60;
            return String.Format("{0:d2}:{1:d2}:{2:d2}", Hours, Minutes, Seconds);
        }
    }
}
