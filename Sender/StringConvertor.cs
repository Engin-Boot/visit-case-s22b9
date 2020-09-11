using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public static class StringConvertor
    {
        public static string ConvertToString(List<string> inputList)
        {
            string outputStringValue = "";
            for (int index = 0; index < inputList.Count; index++)
            {
                outputStringValue += inputList[index] + " ";
            }

            return outputStringValue;
        }
    }
}
