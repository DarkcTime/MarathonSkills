using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonSkills.Classes
{
    public class DateTimeMarathon
    {

        private  DateTime DateTimeStartMarathon = Convert.ToDateTime("21.10.2020");

        public string GetDateTimeBeforeMarathone()
        {
            TimeSpan dateTimeBeforeMarathone = DateTimeStartMarathon.Subtract(DateTime.Now);
            string daysBeforeMaraton = dateTimeBeforeMarathone.ToString("dd");
            string hoursBeforeMaraton = dateTimeBeforeMarathone.ToString("hh");
            string minutesBeforeMaraton = dateTimeBeforeMarathone.ToString("mm");
            string seconds = dateTimeBeforeMarathone.ToString("ss"); 
            return $"{daysBeforeMaraton} дней {hoursBeforeMaraton} часов и {minutesBeforeMaraton} минут до старта марафона!";
        }
    }
}
