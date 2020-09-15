using System;
using System.Collections.Generic;


namespace Recevier
{
    public class TextListSplitter
    {
        public List<int> DayList { get; set; }
        public List<int> MonthList { get; set; }
        public List<int> YearList { get; set; }
        public List<int> HourList { get; set; }
        public List<int> MinuteList { get; set; }
        public bool IsListSpliited { get; set; }
        public TextListSplitter(List<string> textList)
        {
            IsListSpliited = false;
            this.DayList=new List<int>();
            this.MonthList=new List<int>();
            this.YearList=new List<int>();
            this.HourList=new List<int>();
            this.MinuteList=new List<int>();
            this.SplitTextList(textList);
            IsListSpliited = true;
        }
        private List<string> SplitStringIntoValues(string values)
        {
            string[] listEntry = values.Split(' ');
            List<string> splittedValueList = new List<string>();
            try
            {
                for (int index = 0; index < listEntry.Length; index++)
                    splittedValueList.Add(listEntry[index]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Check TextListSplitter->SplitStringIntoValue");
                throw;
            }
            return splittedValueList;
        }
        private string getValueString(string inputString)
        {
            string[] datetypeAndValueString = inputString.Split(':');
            try
            {
                string valueString = datetypeAndValueString[1];
                valueString = valueString.Trim();
                return valueString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e+"  Check TextListSplitter->getValueString");
                throw;
            }
        }
        private void SplitTextList(List<string> textList)
        {
            try
            {
                string valueString = getValueString(textList[1]);
                this.DayList = SplitStringIntoValues(valueString).ConvertAll(int.Parse);
                valueString = getValueString(textList[2]);
                this.MonthList = SplitStringIntoValues(valueString).ConvertAll(int.Parse);
                valueString = getValueString(textList[3]);
                this.YearList = SplitStringIntoValues(valueString).ConvertAll(int.Parse);
                valueString = getValueString(textList[4]);
                this.HourList = SplitStringIntoValues(valueString).ConvertAll(int.Parse);
                valueString = getValueString(textList[5]);
                this.MinuteList = SplitStringIntoValues(valueString).ConvertAll(int.Parse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Check TextSplitter");
                throw;
            }
        }
    }
}
