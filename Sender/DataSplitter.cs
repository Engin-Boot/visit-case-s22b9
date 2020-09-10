using System;
using System.Collections.Generic;
using System.Data;

namespace Sender
{
    public class DataSplitter
    {
        private readonly List<string> dateList= new List<string>();
        private  readonly List<string> timeList=new List<string>();

        public List<string> getDateList()
        {
            return this.dateList;
        }

        public List<string> GetTimeList()
        {
            return this.timeList;
        }

        public void splitIntoDateTimeList(List<string> dataList)
        {
            int sizeOfDataList = dataList.Count;
            for (int index = 0; index < sizeOfDataList; index++)
            {
                string tempEntryOfList = dataList[index];
                string[] dataTimeString = tempEntryOfList.Split(',');
                this.dateList.Add(dataTimeString[0]);
                this.timeList.Add(dataTimeString[1]);
            }

        }
    }
}
