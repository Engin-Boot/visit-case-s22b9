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
            List<string> footFallDataList = reader.DataList;
            
            DataSplitter splittedData = new DataSplitter(footFallDataList);
            List<string> dateList = splittedData.DateList;
            List<string> timeList = splittedData.TimeList;

            ConsoleDisplayer obj=new ConsoleDisplayer();
            obj.DisplayOnConsole(dateList,timeList);
            DataSender sendData=new DataSender();
            sendData.StoreDataInTextFile(dateList,timeList);
            Console.ReadLine();

        }
    }
}
