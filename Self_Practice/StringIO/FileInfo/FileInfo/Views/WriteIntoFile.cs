using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfo.Views
{
    internal class WriteIntoFile
    {
        private string path = @"D:\C#\Self_Practice\StringIO\Documents\test.txt";
        public WriteIntoFile()
        {
            try
            {
                // create a file at pathName and write "Hello World" to the file
                File.WriteAllText(path, "Hello World\n I am Anmol Shrestha.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString);
            }
        }
    } 
}
