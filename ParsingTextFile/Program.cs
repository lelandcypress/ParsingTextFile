using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OutputReader
{
    class parsefile
    {
        static void Main(string[] args)
       
        {
            string path = @"C:\Users\soute\Documents\Fake_Output_Data.txt";
            List<string> OutputFile = new List<string>();
            string resultsHeader = "RESULT_DATA";

            try
            {
                using (StreamReader read = new StreamReader(path))
                {
                    string line = "";
                    while((line=read.ReadLine()) !=null) 
                    {
                        OutputFile.Add(line);

                    }
                    read.Close();
                }

                int resultsHeaderIndx = OutputFile.FindIndex(i => i.Contains(resultsHeader));


            }

            catch (Exception ex) {
                Console.WriteLine("OOOPS " + ex.Message);
            }
        }

        
    }

}