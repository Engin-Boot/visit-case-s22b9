using System;
using System.Collections.Generic;

namespace Sender
{
    
    public class Sender
    {
        public  bool IsExcuted { get; set; }
        public Sender()
        {
            IsExcuted = true;
        }
        static void Main(string[] args)
        {

            CsvFileReader reader = new CsvFileReader();
            List<string> footFallDataList = reader.DataList;
            DataSplitter splittedData = new DataSplitter(footFallDataList);
            List<string> dateList = splittedData.DateList;
            List<string> timeList = splittedData.TimeList;
            ConsoleDisplayer consoleDisplayer=new ConsoleDisplayer();
            consoleDisplayer.DisplayOnConsole(dateList,timeList);
            string enteredDateForAverageFootfallsPerHour = Console.ReadLine();
            Console.WriteLine(enteredDateForAverageFootfallsPerHour);
            string enteredDateForAverageDailyFootfallsInAWeek = Console.ReadLine();
            Console.WriteLine(enteredDateForAverageDailyFootfallsInAWeek);
            string monthYear = Console.ReadLine();
            Console.WriteLine(monthYear);
            
        }
    }
}
