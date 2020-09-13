using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    class Recevier
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
            TextFileReader reader = new TextFileReader();
                TextListSplitter textListSplitter = new TextListSplitter(reader.TextList);
                Aggregator aggregator = new Aggregator(textListSplitter);
                while (true)
                {
                    Console.WriteLine("Enter 1: For Average footfalls per hour, shown over a day");
                    Console.WriteLine("Enter 2: For /Average daily footfalls in a week");
                    Console.WriteLine("Enter 3: For Peak daily footfall in the last month");
                    Console.WriteLine("Enter 0: For Exit");
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice == 1) aggregator.AverageFootfallsPerHourShownOverADay(textListSplitter);
                    else if (choice == 2) aggregator.AverageDailyFootfallsInAWeek(textListSplitter);
                    else if (choice == 3) aggregator.PeakDailyFootfallInTheLastMonth(textListSplitter);
                    else if (choice==0) break;
                    else Console.WriteLine("Please Enter a valid Choice!!");
                }
                
            Console.WriteLine("Exit Successfull!!");
                Console.ReadKey();
            
         
=======
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
>>>>>>> f89b81de26de99f8c7b14cb8c514d00297d0f938
        }
    }
}
