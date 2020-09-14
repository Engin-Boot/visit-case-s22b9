using System;

namespace Recevier
{
    public class Recevier
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Average footfalls per hour, shown over a day-Enter Day(dd/mm/yyyy)");
            Console.WriteLine("For Average daily footfalls in a week-Enter First Day of Week(dd/mm/yyyy)");
            Console.WriteLine("For Peak Daily Foot fall In a Given Month Enter Month Year");
            
            ConsoleReader consoleReader= new ConsoleReader();
            consoleReader.readDataFromConsole();
           
            TextListSplitter textListSplitter = new TextListSplitter(consoleReader.DataList);
            Aggregator aggregator = new Aggregator(textListSplitter);
            aggregator.AverageFootfallsPerHourShownOverADay(textListSplitter,consoleReader.EnteredDateForAverageFootfallsPerHour);
            aggregator.AverageDailyFootfallsInAWeek(textListSplitter,consoleReader.EnteredDateForAverageDailyFootfallsInAWeek);
            aggregator.PeakDailyFootfallInTheLastMonth(textListSplitter,consoleReader.MonthAndYear);
        }
    }
}
