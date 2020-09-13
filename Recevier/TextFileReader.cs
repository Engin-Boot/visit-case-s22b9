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
        public List<string> TextList { get; set; }
        public TextFileReader()
        {
            this.TextList=new List<string>();
            this.ReadTextFile();
        }
        private void ReadTextFile()
        {
            try
            {
                String textInputFilePath = Directory.GetCurrentDirectory();
                String textFileName = "formattedOutput.txt";
                textInputFilePath += @"\" + textFileName;
                Console.WriteLine(textInputFilePath);
                Console.WriteLine("Reading Text File.......");
                StreamReader inputDataStreamReader = new StreamReader(textInputFilePath);
                string line;
                while ((line = inputDataStreamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    TextList.Add(line);
                }

                inputDataStreamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " File Not Found!!--Check TextFileReader");
                throw;
            }
            Console.WriteLine();
        }
    }
}
