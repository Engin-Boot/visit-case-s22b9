using System;
using System.Collections.Generic;

namespace Recevier
{
    public class Aggregator
    {
        public int NoOfRows { get; set; }
        public List<int> IndexList { get; set; }
        public float Average { get; set; }
        public float PeakFootFallInAMonth { get; set; }
        public Aggregator(TextListSplitter textListSplitter)
        {
            NoOfRows = textListSplitter.YearList.Count;
            IndexList = new List<int>();
            Average = 0F;
        }
        
        //Average footfalls per hour, shown over a day
        public void AverageFootfallsPerHourShownOverADay(TextListSplitter textListSplitter)
        {
                Console.Write("Enter Day(dd/mm/yyyy) : ");
                string enteredDate = Console.ReadLine();
                Console.Write("You Entered : {0}", enteredDate);
                string[] ddMmYyDate = enteredDate.Split('/');
                int day = Int16.Parse(ddMmYyDate[0]);
                int month = Int16.Parse(ddMmYyDate[1]);
                int year = Int16.Parse(ddMmYyDate[2]);
                AggregatorSupporter aggregatorSupporter = new AggregatorSupporter();
                IndexList = aggregatorSupporter.GetIndex(day, month, year, textListSplitter, NoOfRows);
                List<int> finalHourList = new List<int>();
                for (int index = 0; index < IndexList.Count; index++)
                {
                    finalHourList.Add(textListSplitter.HourList[IndexList[index]]);
                }

            //printing to console
                Console.WriteLine("------------Average FootFall Per Hour-----------------");
                Console.WriteLine("Given Date : {0}", enteredDate);
                Console.WriteLine("_____________________________");
                Console.WriteLine("Hour   Count");
                var valueVsFreq = ShowFreq(finalHourList);
                Console.WriteLine("Average FootFall Count : {0}", Average);
                Console.WriteLine("_____________________________");
            //Prinitng to file
            string contentToBePrinted = "";
            contentToBePrinted += "Given Date,"+ enteredDate+"\n";
            contentToBePrinted += "Hour,Count\n";
            contentToBePrinted += valueVsFreq;
            contentToBePrinted += "Average FootFall Count,"+Average+"\n"; 
            CsvFileWriter csvFileWriter= new CsvFileWriter();
            csvFileWriter.writeToCsvFile(contentToBePrinted, "AverageFootfallsPerHourShownOverADay");
        }

        //Average daily footfalls in a week
        public void AverageDailyFootfallsInAWeek(TextListSplitter textListSplitter)
        {
                Console.Write("Enter First Day of Week(dd/mm/yyyy) : ");
                string enteredDate = Console.ReadLine();
                Console.Write("You Entered : {0}", enteredDate);
                string[] ddMmYyDate = enteredDate.Split('/');
                int day = Int16.Parse(ddMmYyDate[0]);
                int month = Int16.Parse(ddMmYyDate[1]);
                int year = Int16.Parse(ddMmYyDate[2]);
                DateTime currentDate = Convert.ToDateTime(enteredDate);
                Dictionary<DateTime, int> dayVsCount = new Dictionary<DateTime, int>();
                AggregatorSupporter aggregatorSupporter = new AggregatorSupporter();
                dayVsCount.Add(currentDate,
                    aggregatorSupporter.GetCountPerDay((int) currentDate.Day, (int) currentDate.Month,
                        (int) currentDate.Year, textListSplitter, NoOfRows));
                for (int startDay = 1; startDay <= 6; startDay++)
                {
                    currentDate = currentDate.AddDays(1);
                    dayVsCount.Add(currentDate,
                        aggregatorSupporter.GetCountPerDay((int) currentDate.Day, (int) currentDate.Month,
                            (int) currentDate.Year, textListSplitter, NoOfRows));
                }
                Console.WriteLine("---------Average daily footfalls in a week---------------");
                Console.WriteLine("Given Date : {0}", enteredDate);
                Console.WriteLine("_____________________________");
                Console.WriteLine("Day            Count");
                Average = 0;
                //Prinitng to file
                string contentToBePrinted = "";
                contentToBePrinted += "Given Date," + enteredDate + "\n";
                contentToBePrinted += "Day,Count\n";
                foreach (KeyValuePair<DateTime, int> dayAndFreq in dayVsCount)
                {
                    Console.WriteLine("{0}        {1}", dayAndFreq.Key.ToString("dd/MM/yyyy"), dayAndFreq.Value);
                    Average += (float) dayAndFreq.Value;
                    contentToBePrinted += dayAndFreq.Key.ToString("dd/MM/yyyy") + "," + dayAndFreq.Value + "\n";
                }
                Console.WriteLine("Average FootFall Count : {0}", Average/7);
                contentToBePrinted += "Average FootFall Count," + (Average / 7) + "\n";
                Console.WriteLine("_____________________________");
               
                CsvFileWriter csvFileWriter = new CsvFileWriter();
                csvFileWriter.writeToCsvFile(contentToBePrinted, "AverageDailyFootfallsInAWeek");
        }

        //Peak daily footfall in the last month
        public void PeakDailyFootfallInTheLastMonth(TextListSplitter textListSplitter)
        {
                Console.Write("Enter Month : ");
                int enteredMonth = Int16.Parse(Console.ReadLine());
                Console.Write("Enter Year : ");
                int enteredYear = Int16.Parse(Console.ReadLine());
                Console.Write("You Entered : {0}/{1}", enteredMonth, enteredYear);
                AggregatorSupporter aggregatorSupporter = new AggregatorSupporter();
                IndexList=aggregatorSupporter.GetListOfGivenMonthAndYear(enteredMonth, enteredYear, textListSplitter,NoOfRows);
                //IndexList:which matches with given month and year
                Console.WriteLine(IndexList.Count);
                List<int> finalDayList = new List<int>();
                for (int index = 0; index < IndexList.Count; index++)
                {
                    finalDayList.Add(textListSplitter.DayList[IndexList[index]]);
                }
                Console.WriteLine("-------Peak Daily Footfall In The  Month---------");
                Console.WriteLine("Given Month : {0}", enteredMonth);
                Console.WriteLine("Given Year : {0}", enteredYear);
                Console.WriteLine("_____________________________");
                Console.WriteLine("Day   Count");
                var valShowFreq = ShowFreq(finalDayList);
                Console.WriteLine("Average FootFall Count : {0}", Average);
                Console.WriteLine("Peak FootFall Count : {0}", PeakFootFallInAMonth);
                Console.WriteLine("_____________________________");

                //Prinitng to file
                string contentToBePrinted = "";
                contentToBePrinted += "Given Month," + enteredMonth + "\n";
                contentToBePrinted+= "Given Year,"+enteredYear + "\n";
                contentToBePrinted += "Day,Count" + "\n";
                contentToBePrinted += valShowFreq;
                contentToBePrinted+= "Average FootFall Count,"+ Average+"\n";
                contentToBePrinted += "Peak FootFall Count," + PeakFootFallInAMonth + "\n";
                CsvFileWriter csvFileWriter = new CsvFileWriter();
                csvFileWriter.writeToCsvFile(contentToBePrinted, "PeakDailyFootfallInTheLastMonth");
        }

        public string ShowFreq(List<int> inputList)
        {
                int n = inputList.Count;
                PeakFootFallInAMonth = 0;
                int sum = 0;
                int totalRows = 0;
                string valueVsFreq = "";
                bool[] visited = new bool[n];
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < n; i++)
                {
                    if (visited[i] == true)
                        continue;
                    int count = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (inputList[i] == inputList[j])
                        {
                            visited[j] = true;
                            count++;
                        }
                    }
                    Console.WriteLine(inputList[i] + " " + count);
                    valueVsFreq += inputList[i] + "," + count+"\n";
                    map.Add(inputList[i], count);
                    if (PeakFootFallInAMonth < count)
                    {
                        PeakFootFallInAMonth = count;
                    }
                    totalRows++;
                    sum += count;
                }
                try
                {
                    Average = sum / totalRows;
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + " Check Aggregator->ShowFreq");
                    throw;
                }
                return valueVsFreq;
        }
    }
}

