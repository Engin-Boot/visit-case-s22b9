using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class ConsoleDisplayer
    {
        public void displayOnConsole(List<string> dateList ,List<string> timeList)
        {
            DateFormatter formattedDate = new DateFormatter();
            formattedDate.formatDate(dateList);
            List<string> dayList = formattedDate.getdayList();
            List<string> monthList = formattedDate.GetMonthList();
            List<string> yearList = formattedDate.GetYearList();
            
            TimeFormatter formatTime = new TimeFormatter();
            formatTime.formatTime(timeList);
            List<string> minutList = formatTime.GetMinList();
            List<string> houList = formatTime.getHourList();
            List<string> meridiemList = formatTime.GetMeridiem();
            int numberOfrows = dayList.Count;
            Console.WriteLine("--------Table---------");
            Console.WriteLine("Day      Month       Year     Hour      Minut    Meridiem");
            for (int i = 0; i < dayList.Count; i++)
            {
                Console.WriteLine("{0}        {1}        {2}       {3}        {4}        {5}",
                    dayList[i],monthList[i],yearList[i],houList[i],minutList[i],meridiemList[i]);
            }

        }
    }
}
