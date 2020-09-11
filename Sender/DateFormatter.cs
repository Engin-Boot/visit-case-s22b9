using System;
using System.Collections.Generic;

namespace Sender
{
    public class DateFormatter
    {
        public List<string> DayList { get; set; }
        public List<string> MonthList { get; set; }
        public List<string> YearList { get; set; }

        public bool IsDateFormatted { get; set; }

        public DateFormatter(List<string> dateList)
        {
            this.DayList = new List<string>();
            this.MonthList = new List<string>();
            this.YearList= new List<string>();
            this.GetFormattedDate(dateList);
        }
        private void GetFormattedDate(List<string> dateList)
        {
            try
            {
                int sizeOfDateList = dateList.Count;
                for (int index = 1; index < sizeOfDateList; index++)
                {
                    string date = dateList[index];
                    string[] dd_mm_yyyy = date.Split('/');
                    this.DayList.Add(dd_mm_yyyy[0]);
                    this.MonthList.Add(dd_mm_yyyy[1]);
                    this.YearList.Add(dd_mm_yyyy[2]);
                }

                IsDateFormatted = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Can not Split Into day Month Year!! Check DataFormatter");
                IsDateFormatted = false;
                throw;
            }
        }
    }
}

 