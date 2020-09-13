using System;
using System.Collections.Generic;
using System.IO;

namespace Sender
{
    public class DataSender
    {
        public string OutputFilePath { get; set; }

        public DataSender()
        {
            OutputFilePath = "";
        }

        private void AppendToFile(string dataType, string outputFilePath,List<string> dataList)
        {
            try
            {
                string dataListAsString = dataType;
                dataListAsString += StringConvertor.ConvertToString(dataList);
                File.AppendAllText(outputFilePath, dataListAsString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " Check DataSender->AppendToFile");
                throw;
            }
        }
        public void StoreDataInTextFile(List<string> dateList , List<string> timeList)
        {
            DateFormatter formattedDate = new DateFormatter(dateList);
            List<string> dayList = formattedDate.DayList;
            List<string> monthList = formattedDate.MonthList;
            List<string> yearList = formattedDate.YearList;

            TimeFormatter formattedTime = new TimeFormatter(timeList);
            List<string> minutList = formattedTime.MinutList;
            List<string> hourList = formattedTime.HourList; 
            //List<string> meridiemList = formattedTime.MeridiemList;

            try
            {
                //OutputFilePath = "D:/Bootcamp/Case Study1/visit-case-s22b9/Recevier/formattedOutput.txt";
                OutputFilePath = "D:/Bootcamp/Final Sender Recevier/VisitCount/Recevier/bin/Debug/formattedOutput.txt";

                string text1 = "Type of Data      Values";
                File.WriteAllText(OutputFilePath, text1);

                this.AppendToFile("\n Day : ", OutputFilePath, dayList);
                this.AppendToFile("\n Month : ", OutputFilePath, monthList);
                this.AppendToFile("\n Year : ", OutputFilePath, yearList);
                this.AppendToFile("\n Minutes : ", OutputFilePath, minutList);
                this.AppendToFile("\n Hour : ", OutputFilePath, hourList);
               // this.AppendToFile("\n Am/PM : ", OutputFilePath, meridiemList);
                Console.WriteLine(File.ReadAllText(OutputFilePath));
            }
            catch (Exception e)
            {
                Console.WriteLine(e+ "Unable to send data to recevier!! Check DataSender");
                OutputFilePath = "";
                throw;
            }
         
           
        }
    }
}
