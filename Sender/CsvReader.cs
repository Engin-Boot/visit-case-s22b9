using System;
using System.IO;

namespace Sender
{
    public class CsvReader
    {
        static string inputCSVFilePath = "D:/Bootcamp/Case Study1/visit-case-s22b9/Sender/InputFootFallsData.csv";
        private string[] lines = File.ReadAllLines(inputCSVFilePath);
        private int line;

        public void ReadCSVFile()
        { 
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                    Console.WriteLine(column);
                }
            }
        }




    }

}
