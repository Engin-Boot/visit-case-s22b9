using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    class Aggregate
    {
        public void HourlyFootfallsPerDay(int day)
        {
            int startIndex = Recevier.dayList.FindIndex(x => x == day);
            int lastIndex = Recevier.dayList.FindLastIndex(x => x == day);
            
            for (int index = startIndex; index <= lastIndex; index++)
            {
                Console.WriteLine(Recevier.hourList[index]);
            }


        }
    }
}
