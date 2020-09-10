using System;
using System.Collections.Generic;
using  System.IO;
namespace Sender
{
    class CsvFileReader
    {
        private List<string> dataList = new List<string>();
        public List<string> ReadCsvFile()
        {
            string csvFilePath = "D:/Bootcamp/Final Sender Recevier/VisitCount/Sender/InputFootFallsData.csv";
            Console.WriteLine("Reading CSV File.......");
            if (File.Exists(csvFilePath))
            {
                StreamReader inputDataStreamReader = new StreamReader(csvFilePath);
                string line;
                while ((line = inputDataStreamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    this.dataList.Add(line);
                }

                inputDataStreamReader.Close();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("File Not Found!!");
            }
            Console.WriteLine();
            return this.dataList;
        }
    }
    
}
