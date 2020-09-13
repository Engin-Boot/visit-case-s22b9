using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recevier
<<<<<<< HEAD
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
=======
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
>>>>>>> f89b81de26de99f8c7b14cb8c514d00297d0f938
        }
    }
}
