using System;
using System.Collections.Generic;
using System.IO;
using Recevier;
using Xunit;
using Recevier = Recevier.Recevier;

namespace Receiver.Test
{
    public class ReceiverTests
    {
        
      
        [Fact]
        public void AggreGatorSupporterTest()
        {
            AggregatorSupporter aggregatorSupporter=new AggregatorSupporter();
            Assert.True(aggregatorSupporter.IsSupporterWork);
            
        }

        /*[Fact]
        public void TestForConsoleReader()
        {
            ConsoleReader consoleReader=new ConsoleReader();
            consoleReader.TextList= new List<string>{"Data Type Value", "Day : 11", "Month : 11", "Year: 2011", "Hour:05", "Minute:11", "11/11/2011", "11/11/2011", "11 2011"};
            consoleReader.readDataFromConsole();
            Assert.True(consoleReader.IsDataRead);
        }*/
        [Fact]
        public void TestForConsoleReaderClass()
        {
            ConsoleReader consoleReader=new ConsoleReader();
            Assert.True(consoleReader.IsDataRead);
        }

        [Fact]
        public void TestForTextListSplitter()
        {
            ConsoleReader consoleReader = new ConsoleReader();
            consoleReader.DataList = new List<string> { "Data Type Value", "Day : 11", "Month : 11", "Year: 2011", "Hour:05", "Minute:11"};
            TextListSplitter textListSplitter =new TextListSplitter(consoleReader.DataList);
            Assert.True(textListSplitter.IsListSpliited);
        }

        [Fact]
        public void WhenCSVFileWriterCalledWriteDataIntoCsvFile()
        {
            CsvFileWriter csvFileWriter=new CsvFileWriter();
            csvFileWriter.writeToCsvFile("Unit Test For Csv File Writer", "WhenCSVFileWriterCalledWriteDataIntoCsvFile");
            Assert.True(csvFileWriter.IsDataWritten);
        }

        [Fact]
        public void WhenAggregatorSupporterCalledThenCallSupportingFunction()
        {
            AggregatorSupporter aggregatorSupporter=new AggregatorSupporter();
            ConsoleReader consoleReader = new ConsoleReader();
            consoleReader.DataList = new List<string> { "Data Type Value", "Day : 11", "Month : 11", "Year: 2011", "Hour:05", "Minute:11" };
            TextListSplitter textListSplitter = new TextListSplitter(consoleReader.DataList);
            Assert.True(aggregatorSupporter.IsSupporterWork);
            aggregatorSupporter.GetCountPerDay(11, 11, 2011, textListSplitter, textListSplitter.DayList.Count);
            Assert.True(aggregatorSupporter.IsGetCountPerDayWorks);
            aggregatorSupporter.GetIndex(11, 11, 2011, textListSplitter, textListSplitter.DayList.Count);
            Assert.True(aggregatorSupporter.IsGetIndexWorks);
            aggregatorSupporter.GetListOfGivenMonthAndYear(11, 2011,  textListSplitter, textListSplitter.DayList.Count);
            Assert.True(aggregatorSupporter.IsGetListOfGivenMonthAndYear);
        }

        [Fact]
        public void WhenAggregatorCalledThenCallFunctions()
        {
            ConsoleReader consoleReader = new ConsoleReader();
            consoleReader.DataList = new List<string> { "Data Type Value", "Day : 11", "Month : 11", "Year: 2011", "Hour:05", "Minute:11" };
            TextListSplitter textListSplitter = new TextListSplitter(consoleReader.DataList);
            Aggregator aggregator=new Aggregator(textListSplitter);
            Assert.True(aggregator.IsAggregatorCalled);
            aggregator.AverageFootfallsPerHourShownOverADay(textListSplitter,"11/11/2011");
            Assert.True(aggregator.CheckAverageFootfallsPerHourShownOverADay);
            aggregator.AverageDailyFootfallsInAWeek(textListSplitter,"11/11/2011");
            Assert.True(aggregator.CheckAverageDailyFootfallsInAWeek);
            aggregator.PeakDailyFootfallInTheLastMonth(textListSplitter,"11 2011");
            Assert.True(aggregator.CheckPeakDailyFootfallInTheLastMonth);
        }

       

    }
}
