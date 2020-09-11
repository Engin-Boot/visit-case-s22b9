using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
{
    class TextFileReader
    {
        private List<string> textList = new List<string>();
        public List<string> ReadTextFile()
        {
            string textFilePath = "C:/Users/320104254/source/repos/Bootcamp/Final Sender Recevier/Recevier/formattedOutput.txt";
            Console.WriteLine("Reading Text File.......");
            if (File.Exists(textFilePath))
            {
                StreamReader inputStreamReader = new StreamReader(textFilePath);
                string line;
                while ((line = inputStreamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    this.textList.Add(line);
                    
                }
                
                inputStreamReader.Close();
            }
            else
            {
                Console.WriteLine("File Not Found!!");
            }
            Console.WriteLine();
            return this.textList;
        }
    }
}
