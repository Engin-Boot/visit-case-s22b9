using System;
using System.Collections.Generic;
using System.IO;

namespace Sender
{
    public class DataSender
    {
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
            List<string> meridiemList = formattedTime.MeridiemList;

            try
            {
                string outputFilePath = "D:/Bootcamp/Case Study1/visit-case-s22b9/Recevier/formattedOutput.txt";

                string text1 = "Type of Data      Values";
                File.WriteAllText(outputFilePath, text1);

                this.AppendToFile("\n Day : ", outputFilePath, dayList);
                this.AppendToFile("\n Month : ", outputFilePath, monthList);
                this.AppendToFile("\n Year : ", outputFilePath, yearList);
                this.AppendToFile("\n Minutes : ", outputFilePath, minutList);
                this.AppendToFile("\n Hour : ", outputFilePath, hourList);
                this.AppendToFile("\n Am/PM : ", outputFilePath, meridiemList);
                Console.WriteLine(File.ReadAllText(outputFilePath));
            }
            catch (Exception e)
            {
                Console.WriteLine(e+ "Unable to send data to recevier!! Check DataSender");
                throw;
            }
         
           
        }
    }
}
