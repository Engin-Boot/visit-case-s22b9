using System;
using System.Collections.Generic;
using System.IO;

namespace Sender
{
    public class DataSender
    {
        public void storeDataInTextFile(List<string> dateList , List<string> timeList)
        {
            DateFormatter formattedDate = new DateFormatter();
            formattedDate.formatDate(dateList);
            List<string> dayList = formattedDate.getdayList();
            List<string> monthList = formattedDate.GetMonthList();
            List<string> yearList = formattedDate.GetYearList();

            TimeFormatter formatTime = new TimeFormatter();
            formatTime.formatTime(timeList);
            List<string> minutList = formatTime.GetMinList();
            List<string> houList = formatTime.getHourList();
            List<string> meridiemList = formatTime.GetMeridiem();

            
            string outputFilePath = "D:/Bootcamp/Final Sender Recevier/VisitCount/Recevier/formattedOutput.txt";

            string text1 = "Type of Data      Values";
            File.WriteAllText(outputFilePath, text1);

            string dayListAsString = "\n Day : ";
            dayListAsString +=StringConvertor.ConvertToString(dayList);
            File.AppendAllText(outputFilePath, dayListAsString);

            string monthListAsString = "\n Month : ";
            monthListAsString += StringConvertor.ConvertToString(monthList);
            File.AppendAllText(outputFilePath, monthListAsString);

            string yearListAsString = "\n Year : ";
            yearListAsString += StringConvertor.ConvertToString(yearList);
            File.AppendAllText(outputFilePath, yearListAsString);

            string minListAsString = "\n Minutes : ";
            minListAsString += StringConvertor.ConvertToString(minutList);
            File.AppendAllText(outputFilePath, minListAsString);

            string hourListAsString = "\n Hour : ";
            hourListAsString += StringConvertor.ConvertToString(houList);
            File.AppendAllText(outputFilePath, hourListAsString);

            string memeridiemListAsString = "\n Am/PM : ";
            memeridiemListAsString += StringConvertor.ConvertToString(meridiemList);
            File.AppendAllText(outputFilePath, memeridiemListAsString);


            // To display current contents of the file 
            Console.WriteLine(File.ReadAllText(outputFilePath));
            Console.ReadKey();


        }
    }
}
