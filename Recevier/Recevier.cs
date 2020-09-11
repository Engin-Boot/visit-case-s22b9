using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    class Recevier
    {
        public static List<int> yearList;
        public static List<int> monthList;
        public static List<int> dayList;
        public static List<int> hourList;
        public static List<int> minuteList;
        
        static void Main(string[] args)
        {
            TextFileReader reader = new TextFileReader();
            List<string> textList = reader.ReadTextFile();
            ListSplitter splittedList = new ListSplitter();
            splittedList.SplitIntoLists(textList);
            yearList = splittedList.GetYearList();
            monthList = splittedList.GetMonthList();
            dayList = splittedList.GetDayList();
            hourList = splittedList.GetHourList();
            minuteList = splittedList.GetMinuteList();
            Aggregate aggregate = new Aggregate();
            aggregate.HourlyFootfallsPerDay(2);
            Console.ReadKey();
        }
    }
}
