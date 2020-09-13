using System;
using System.IO;
using Recevier;
using Xunit;
using Recevier = Recevier.Recevier;

namespace Receiver.Test
{
    public class ReceiverTests
    {
        [Fact]
        public void WhenTextFileReaderCalledThenReadFIle()
        {
            TextFileReader textFileReader = new TextFileReader();
            Assert.True(textFileReader.IsFileRead);
            Console.WriteLine("WhenTextFileReaderCalledThenReadFIle Done!");
        }

        [Fact]
        public void WhenTextListSplitterCalledThenSplitIt()
        {
            TextFileReader textFileReader = new TextFileReader();
            TextListSplitter textListSplitter = new TextListSplitter(textFileReader.TextList);
            Assert.True(textListSplitter.IsListSpliited);
            Console.WriteLine("WhenTextListSplitterCalledThenSplitIt Done!");
        }
        [Fact]
        public void AggregatorCalledTest()
        {
            TextFileReader textFileReader = new TextFileReader();
            TextListSplitter textListSplitter = new TextListSplitter(textFileReader.TextList);
            Aggregator aggregator = new Aggregator(textListSplitter);
            Assert.True(aggregator.IsAggregatorCalled);

        }

        [Fact]
        public void AggreGatorSupporterTest()
        {
            AggregatorSupporter aggregatorSupporter=new AggregatorSupporter();
            Assert.True(aggregatorSupporter.IsGetCountPerDayWorks);
            Assert.True(aggregatorSupporter.IsGetIndexWorks);
            Assert.True(aggregatorSupporter.IsGetListOfGivenMonthAndYear);
        }
        
        
    }
}
