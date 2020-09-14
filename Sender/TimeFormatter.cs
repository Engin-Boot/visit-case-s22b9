using System;
using System.Collections.Generic;

namespace Sender
{
    public class TimeFormatter
    {
        public List<string> HourList { get; set; }
        public List<string> MinutList { get; set; }
        public bool IsTimeFormatted { get; set; }

        public TimeFormatter(List<string> timeList)
        {
            this.HourList=new List<string>();
            this.MinutList=new List<string>();
            this.GetFormattedDate(timeList);
        }
        private void GetFormattedDate(List<string> timeList)
        {
            try
            {
                int sizeOfTimeList = timeList.Count;
                for (int index = 1; index < sizeOfTimeList; index++)
                {
                    string time = timeList[index];
                    string[] hourNMinStr = time.Split(':');
                    this.HourList.Add(hourNMinStr[0]);
                    this.MinutList.Add(hourNMinStr[1]);
                }
                IsTimeFormatted = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Con not Split into Hour Min AM/Pm!! Check TimeFormatter");
                IsTimeFormatted = false;
                throw;
            }
        }

    }
    }


