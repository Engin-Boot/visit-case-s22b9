using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    public  class AggregatorSupporter
    {
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
