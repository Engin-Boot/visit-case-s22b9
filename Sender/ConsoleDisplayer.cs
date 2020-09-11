using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class ConsoleDisplayer
    {
        public int NumberOfRows { get; set; }

        public ConsoleDisplayer()
        {
            NumberOfRows = 0;
        }

        public void DisplayOnConsole(List<string> dateList ,List<string> timeList)
        {
            try
            {
                DateFormatter formattedDate = new DateFormatter(dateList);
                List<string> dayList = formattedDate.DayList;
                List<string> monthList = formattedDate.MonthList;
                List<string> yearList = formattedDate.YearList;

                TimeFormatter formattedTime = new TimeFormatter(timeList);
                List<string> minutList = formattedTime.MinutList;
                List<string> houList = formattedTime.HourList;
                List<string> meridiemList = formattedTime.MeridiemList;

                NumberOfRows = dayList.Count;
                Console.WriteLine("--------Table---------");
                Console.WriteLine("Day      Month       Year     Hour      Minut    Meridiem");
                for (int i = 0; i < dayList.Count; i++)
                {
                    Console.WriteLine("{0}        {1}        {2}       {3}        {4}        {5}",
                        dayList[i], monthList[i], yearList[i], houList[i], minutList[i], meridiemList[i]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Check ConsoleDisplayer");
                NumberOfRows = 0;
                throw;
            }
           

        }
    }
}
