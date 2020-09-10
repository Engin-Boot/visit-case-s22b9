using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class DateFormatter
    {
        private readonly List<string> dayList=new List<string>();
        private readonly List<string> monthList=new List<string>();
        private readonly List<string> yearList=new List<string>();

        public List<string> getdayList()
        {
            return this.dayList;
        }

        public List<string> GetMonthList()
        {
            return this.monthList;
        }

        public List<string> GetYearList()
        {
            return this.yearList;
        }

        public void formatDate(List<string> dateList)
        {
            int sizeOfDateList = dateList.Count;
            for (int index = 1; index < sizeOfDateList; index++)
            {
                string date = dateList[index];
                string[] dd_mm_yyyy = date.Split('/');
                this.dayList.Add(dd_mm_yyyy[0]);
                this.monthList.Add(dd_mm_yyyy[1]);
                this.yearList.Add(dd_mm_yyyy[2]);
            }
        }
    }
}

 