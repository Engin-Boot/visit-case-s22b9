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
        private void displayOnConsole(string dataType, List<string> values)
        {
            Console.Write(dataType+" : ");
            for (int index = 0; index < values.Count; index++)
            {
                Console.Write(values[index] +" ");
            }
            Console.WriteLine();
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
                List<string> hourList = formattedTime.HourList;

                Console.WriteLine("Data Type   Values");
                displayOnConsole("Day",dayList);
                displayOnConsole("Month", monthList);
                displayOnConsole("Year", yearList);
                displayOnConsole("Hour", minutList);
                displayOnConsole("Minute", hourList);
                NumberOfRows = dayList.Count;
                

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
