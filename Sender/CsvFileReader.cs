using System;
using System.Collections.Generic;
using  System.IO;
namespace Sender
{
    public class CsvFileReader
    {
        public List<string> DataList { get; set; }
        public CsvFileReader()
        {
            DataList=new List<string>();
            this.ReadCsvFile();
        }
        private void ReadCsvFile()
        {
            var csvInputFilePath = "D:/Bootcamp/Case Study1/visit-case-s22b9/Sender/InputFootFallsData.csv";
            Console.WriteLine("Reading CSV File.......");
            try
            {
                    StreamReader inputDataStreamReader = new StreamReader(csvInputFilePath);
                    string line;
                    while ((line = inputDataStreamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        DataList.Add(line);
                    }

                    inputDataStreamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" File Not Found!!--Check CsvFileReader");
                throw;
            }
            Console.WriteLine();
        }
    }
    
}
