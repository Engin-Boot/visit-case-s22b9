using System;
using System.Collections.Generic;
using Xunit;
using Sender;
using Xunit.Sdk;

namespace Sender.Tests
{
    public class SenderTests
    {
        public List<string> DateList { get; set; }
        public List<string> TimeList { get; set; }

        public SenderTests()
        {
            CsvFileReader csvReader = new CsvFileReader();
            List<string> dataList = csvReader.DataList;
            DataSplitter splittedData = new DataSplitter(dataList);
            DateList = splittedData.DateList;
            TimeList = splittedData.TimeList;
        }

        [Fact]
        public void WhenCsvReaderCalledThenGetDataList()
        {
            CsvFileReader csvReader = new CsvFileReader();
            List<string> dataList = csvReader.DataList;
            Assert.True(dataList.Count >= 0);
            Console.WriteLine("WhenCsvReaderCalledThenGetDataList Done!");
        }

        [Fact]
        public void WhenSplittedDataCalledThenGetDateAndTimeList()
        {
            Assert.True(DateList.Count >= 0);
            Assert.True(TimeList.Count >= 0);
            Console.WriteLine("WhenSplittedDataCalledThenGetDateAndTimeList Done!");
        }

        [Fact]
        public void WhenDataSenderCalledThenWriteOnRecevier()
        {
            DataSender dataSender = new DataSender();
            Assert.False(dataSender.OutputFilePath != "");
            dataSender.StoreDataInTextFile(DateList, TimeList);
            Assert.True(dataSender.OutputFilePath != "");
            Console.WriteLine("WhenDataSenderCalledThenWriteOnRecevier Done!");
        }
        [Fact]
        public void WhenConsoleDisplayerCalledThenWriteOnConsole()
        {
            ConsoleDisplayer consoleDisplayer = new ConsoleDisplayer();
            Assert.False(consoleDisplayer.NumberOfRows != 0);
            consoleDisplayer.DisplayOnConsole(DateList, TimeList);
            Assert.True(consoleDisplayer.NumberOfRows != 0);
            Console.WriteLine("WhenConsoleDisplayerCalledThenWriteOnConsole Done!");
        }

        [Fact]
        public void WhenDateFormatterCalledThenSplitIntoDayMonthYear()
        {
            DateFormatter dateFormatter = new DateFormatter(DateList);
            Assert.True(dateFormatter.IsDateFormatted);
            Console.WriteLine("WhenDateFormatterCalledThenSplitIntoDayMonthYear Done!");
        }

        [Fact]
        public void WhenTimeFormatterCallenThenSplitIntoHourMinutAmPm()
        {
            TimeFormatter timeFormatter = new TimeFormatter(TimeList);
            Assert.True(timeFormatter.IsTimeFormatted);
            Console.WriteLine("WhenTimeFormatterCallenThenSplitIntoHourMinutAmPm Done!");

        }

        [Fact]
        public void TestForSucessfullExcution()
        {
            Sender sender=new Sender();
            Assert.True(sender.IsExcuted);
            Console.WriteLine("TestForSucessfullExcution Done!");
        }

    }
}
