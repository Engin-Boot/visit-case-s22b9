using System;
using System.Collections.Generic;
using  System.IO;
<<<<<<< HEAD
=======

>>>>>>> e0c704601feec73f90ee0ec2f1a310f929c0d111
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
<<<<<<< HEAD
            String csvInputFilePath = Directory.GetCurrentDirectory();
            String csvFileName = "InputFootFallsData.csv";
            csvInputFilePath += @"\" + csvFileName;
=======
            String binDebugNetCorePath = Directory.GetCurrentDirectory();
            String csvInputFilePath = Path.GetFullPath(Path.Combine(binDebugNetCorePath, @"..\..\"));
            String csvFileName = "InputFootFallsData.csv";
            csvInputFilePath += @"\" + csvFileName;

>>>>>>> e0c704601feec73f90ee0ec2f1a310f929c0d111
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
