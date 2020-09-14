using System;
using System.Collections.Generic;

namespace Recevier
{
    public class ConsoleReader
    {
        public List<string> TextList { get; set; }
        public List<string> DataList { get; set; }
        public string EnteredDateForAverageFootfallsPerHour { get; set; }
        public string EnteredDateForAverageDailyFootfallsInAWeek { get; set; }
        public string MonthAndYear { get; set; }
        public ConsoleReader()
        {
            TextList =new List<string>();
            DataList=new List<string>();
        }

        public void readDataFromConsole()
        {
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                TextList.Add(input);
                input = Console.ReadLine();
            }
            if (TextList != null)
            {
                foreach (string s in TextList)
                {
                    Console.WriteLine(s);
                }
                
                for (int i = 0; i <=5; i++)
                {
                    DataList.Add(TextList[i]);
                }
                Console.WriteLine("Count : {0}", DataList.Count);
                Console.WriteLine("Count : {0}", TextList.Count);
                EnteredDateForAverageFootfallsPerHour = TextList[6];
                EnteredDateForAverageDailyFootfallsInAWeek = TextList[7];
                MonthAndYear = TextList[8];
            }
        }
    }
}
