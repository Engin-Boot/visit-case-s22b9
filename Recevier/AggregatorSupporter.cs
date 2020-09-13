using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    public  class AggregatorSupporter
    {
        public bool IsSupporterWork { get; set; }
        public bool IsGetCountPerDayWorks { get; set; }
        public bool IsGetIndexWorks { get; set; }
        public bool IsGetListOfGivenMonthAndYear { get; set; }

        public AggregatorSupporter()
        {
            IsGetIndexWorks = true;
            IsGetCountPerDayWorks = true;
            IsGetListOfGivenMonthAndYear = true;
            IsSupporterWork = true;
        }

        public int GetCountPerDay(int day, int month, int year, TextListSplitter textListSplitter,int noOfRows)
        {
            try
            {
                int count = 0;
                for (int index = 0; index < noOfRows; index++)
                {
                    if (day == textListSplitter.DayList[index]
                        && month == textListSplitter.MonthList[index]
                        && year == textListSplitter.YearList[index])
                    {
                        count++;
                    }
                }

                IsGetCountPerDayWorks = true;
                return count;

            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Check AggregatorSupporter");
                throw;
            }
        }

        public List<int> GetIndex(int day, int month, int year, TextListSplitter textListSplitter,int noOfRows)
        {
            try
            {
                List<int> indexList = new List<int>();
                for (int index = 0; index < noOfRows; index++)
                {
                    if (day == textListSplitter.DayList[index]
                        && month == textListSplitter.MonthList[index]
                        && year == textListSplitter.YearList[index])
                    {
                        indexList.Add(index);
                    }
                }

                IsGetIndexWorks = true;
                return indexList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Check AggregatorSupporter->GetIndex");
                throw;
            }
       
        }
        public List<int> GetListOfGivenMonthAndYear(int month, int year, TextListSplitter textListSplitter,int noOfRows)
        {
            try
            {
                List<int> indexList = new List<int>();
                for (int index = 0; index < noOfRows; index++)
                {
                    if (month == textListSplitter.MonthList[index]
                        && year == textListSplitter.YearList[index])
                    {
                        indexList.Add(index);
                    }
                }

                IsGetListOfGivenMonthAndYear = true;
                return indexList;

            }
            catch (Exception e)
            {
                Console.WriteLine(e+ " Check AggregatorSupporter-> GetListOfGivenMonthAndYear");
                throw;
            }
        }
    }
}
