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
        List<string> headerReportRaw = OutputFile.GetRange(1, resultsHeaderIndx - 1);
        List<string> resultsReportRaw = OutputFile.GetRange(resultsHeaderIndx+1, OutputFile.Count - resultsHeaderIndx - 1);
        headerReportRaw =  headerReportRaw.Distinct().ToList();
        resultsReportRaw[0] = Regex.Replace(resultsReportRaw[0], @"\[|\]", "");
        
        File.WriteAllLines(@"C:\Users\soute\Documents\Fake_Header_Data.txt", headerReportRaw);
        File.WriteAllLines(@"C:\Users\soute\Documents\Fake_Results_Data.txt", resultsReportRaw);
    }
    
}

catch (Exception ex)
{
    Console.WriteLine("OOOPS " + ex.Message);
}
