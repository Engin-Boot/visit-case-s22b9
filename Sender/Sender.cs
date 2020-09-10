using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    class Sender
    {
        static void Main(string[] args)
        { 
            CsvFileReader reader = new CsvFileReader();
            List<string> dataList= reader.ReadCsvFile();
            DataSplitter splittedData = new DataSplitter();
            splittedData.splitIntoDateTimeList(dataList);
            List<string> dateList = splittedData.getDateList();
            List<string> timeList = splittedData.GetTimeList();
            ConsoleDisplayer obj=new ConsoleDisplayer();
            obj.displayOnConsole(dateList,timeList);
            Console.ReadLine();
        }
    }
}
