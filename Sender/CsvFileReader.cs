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
            String csvInputFilePath = Directory.GetCurrentDirectory();
            String csvFileName = "InputFootFallsData.csv";
            csvInputFilePath += @"\" + csvFileName;
            try
            {
                    StreamReader inputDataStreamReader = new StreamReader(csvInputFilePath);
                    string line;
                    while ((line = inputDataStreamReader.ReadLine()) != null)
                    {
                        DataList.Add(line);
                    }
                    inputDataStreamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" File Not Found!!--Check CsvFileReader");
                throw;
            }
        }
    }
    
}
