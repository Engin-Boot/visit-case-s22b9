using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    public class Recevier
    {
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
            
         
        }
    }
}
