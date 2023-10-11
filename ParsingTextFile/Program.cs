using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

string path = @"C:\Users\soute\Documents\Fake_Output_Data.txt";
List<string> OutputFile = new List<string>();
string resultsHeader = "RESULT_DATA";

try
{
    //save whole file into a list 
    using (StreamReader read = new StreamReader(path))
    {
        string line = "";
        while ((line = read.ReadLine()) != null)
        {
            OutputFile.Add(line);

        }
        read.Close();
    }
    //searches through list and finds "RESULTS_DATA" since this will be how we break out the two files
    int resultsHeaderIndx = OutputFile.FindIndex(i => i.Contains(resultsHeader));
    if (resultsHeaderIndx >= 0)
    {
        List<string> headerReportRaw = OutputFile.GetRange(0, resultsHeaderIndx - 1);
        List<string> resultsReportRaw = OutputFile.GetRange(resultsHeaderIndx, OutputFile.Count - resultsHeaderIndx - 1);
        resultsReportRaw[1] = Regex.Replace(resultsReportRaw[1], @"\[|\]", "");
        Console.WriteLine(resultsReportRaw[1]);

    }
    
}

catch (Exception ex)
{
    Console.WriteLine("OOOPS " + ex.Message);
}
