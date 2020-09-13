using System;
using System.IO;

namespace Recevier
{
    public class CsvFileWriter
    {
        public void writeToCsvFile(string content,string fuctionName)
        {
            String csvOutputFilePath = Directory.GetCurrentDirectory();
            String currentTime=DateTime.Now.ToString("yyyy_MM_dd");
            String csvFileName = currentTime+ fuctionName+"outputFootFallData.csv";
            csvOutputFilePath += @"\" + csvFileName;
            using (StreamWriter w = File.AppendText(csvOutputFilePath)) 
            {
                w.WriteLine("\n\n");
                w.WriteLine(DateTime.Now.ToString("HH-mm-ss"));
                w.WriteLine(content);
            }
        }
    }
}
