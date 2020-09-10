using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class TimeFormatter
    {
        private readonly List<string> hourList=new List<string>();
        private readonly List<string> minList=new List<string>();
        private readonly List<string> meridiemList=new List<string>();

        public List<string> getHourList()
        {
            return this.hourList;
        }

        public List<string> GetMinList()
        {
            return this.minList;
        }

        public List<string> GetMeridiem()
        {
            return this.meridiemList;
        }

        public void formatTime(List<string> timeList)
        {
            int sizeOfTimeList = timeList.Count;
            for (int index = 1; index < sizeOfTimeList; index++)
            {

                string time = timeList[index];
                string[] splitIntoTimeAndMeridiem = time.Split(' ');
                this.meridiemList.Add(splitIntoTimeAndMeridiem[1]);
                string onlyTime = splitIntoTimeAndMeridiem[0];
                string[] hourNMinStr = onlyTime.Split(':');
                this.hourList.Add(hourNMinStr[0]);
                this.minList.Add(hourNMinStr[1]);
            }
        }

    }
    }


