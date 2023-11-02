using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfo.Views
{
    internal class ReadFile
    {
        private string path = @"D:\C#\Self_Practice\StringIO\Documents\test.txt";
        public ReadFile()
        {
            try
            {
                // read the content of myFile.txt file
                string readText = File.ReadAllText(path);

                // Print the content of test.txt file.
                Console.WriteLine(readText);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString);
            }
        }
    }
}
