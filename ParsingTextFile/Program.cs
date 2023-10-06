using System;
using System.IO;
using System.Text;

namespace OutputReader
{
    class parsefile
    {

        public static void Main(string[] args)
        {
            string path = @"C:\Users\soute\Documents\Fake_Output_Data.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("YIPPEE");
            }
            else
            {
                Console.WriteLine("OOOOH NOOOOOO");
            }
        }
    }

}