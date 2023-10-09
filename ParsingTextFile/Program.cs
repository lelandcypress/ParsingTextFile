using System;
using System.IO;
using System.Text;

namespace OutputReader
{
    class parsefile
    {
       
        static void readFile( string FilePath)
        {

            try
            {

                using (StreamReader read = new StreamReader(FilePath))
                {
                    //Console.WriteLine(read.ReadToEnd()); //Only use for shorter blocks since it reads the whole output at once, can cause issues with large files//

                    string line = "";
                    while((line=read.ReadLine()) !=null) 
                    {
                        Console.WriteLine(line); 

                    }
                    read.Close();


                   /* int charCode;
                    while ((charCode = read.Read()) != -1)
                    {
                        char c = (char)charCode;
                        //Console.Write(c);
                    }*/
                    read.Close();

                }

            }



            catch (Exception ex) {
                Console.WriteLine("OOOPS " + ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            string path = @"C:\Users\soute\Documents\Fake_Output_Data.txt";
     

            if (File.Exists(path))
            {
                readFile(path);
            }
            else
            {
                Console.WriteLine("no matching file found");
            }
        }
    }

}