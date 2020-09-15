using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    public class ListSplitter
    {
        private List<int> dayList = new List<int>();
        private List<int> monthList = new List<int>();
        private List<int> yearList = new List<int>();
        private List<int> hourList = new List<int>();
        private List<int> minuteList = new List<int>();
        //private List<string> meridiemList = new List<string>();
        private List<string> stringList;
        public List<string> StringSplitter(string line)
        {
            stringList = new List<string>();
            string[] listEntry = line.Split(' ');
            foreach(string field in listEntry)
            {
                this.stringList.Add(field);
            }
            return this.stringList;
        }
        public List<int> GetDayList()
        {
            return this.dayList;
        }
        public List<int> GetMonthList()
        {
            return this.monthList;
        }
        public List<int> GetYearList()
        {
            return this.yearList;
        }
        public List<int> GetHourList()
        {
            return this.hourList;
        }
        public List<int> GetMinuteList()
        {
            return this.minuteList;
        }
        /*public List<string> GetMeridiemList()
        {
            return this.meridiemList;
        }*/

        public void SplitIntoLists(List<string> textList)
        {
            
            this.dayList = StringSplitter(textList[0]).Select(int.Parse).ToList();
            this.monthList = StringSplitter(textList[1]).Select(int.Parse).ToList();
            this.yearList = StringSplitter(textList[2]).Select(int.Parse).ToList();
            this.hourList = StringSplitter(textList[3]).Select(int.Parse).ToList();
            this.minuteList = StringSplitter(textList[4]).Select(int.Parse).ToList();
            //this.meridiemList = StringSplitter(textList[5]);
        }
    }
}
