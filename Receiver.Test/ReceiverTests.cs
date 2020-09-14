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
        public void AggreGatorSupporterTest()
        {
            AggregatorSupporter aggregatorSupporter=new AggregatorSupporter();
            Assert.True(aggregatorSupporter.IsGetCountPerDayWorks);
            Assert.True(aggregatorSupporter.IsGetIndexWorks);
            Assert.True(aggregatorSupporter.IsGetListOfGivenMonthAndYear);
        }
        
        
    }
}
