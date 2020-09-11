using System;
using System.Collections.Generic;

namespace Sender
{
    public class DataSplitter
    {
        public List<string> DateList { get; set; }
        public List<string> TimeList { get; set; }
        public DataSplitter(List<string> dataList)
        {
            this.DateList=new List<string>();
            this.TimeList=new List<string>();
            this.SplitIntoDateTimeList(dataList);
        }
        
        private void SplitIntoDateTimeList(List<string> dataList)
        {
            try
            {
                int sizeOfDataList = dataList.Count;
                for (int index = 0; index < sizeOfDataList; index++)
                {
                    string tempEntryOfList = dataList[index];
                    string[] dateAndTimeString = tempEntryOfList.Split(',');
                    this.DateList.Add(dateAndTimeString[0]);
                    this.TimeList.Add(dateAndTimeString[1]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Can not split into Date and time!!--Check DataSplitter");
                throw;
            }

        }
    }
}
