using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfo.Views
{
    internal class FileCreate
    {
        public FileCreate()
        {
            try
            {
                // Path of file
                string pathName = @"D:\C#\Self_Practice\StringIO\Douments\test.txt";

                // Create() creates a file at filepath
                FileStream fs = File.Create(pathName);

                // chCheck test.txt file is created at the specified path 
                if (File.Exists(pathName))
                {
                    Console.WriteLine("File is created.");
                }
                else
                {
                    Console.WriteLine("File is not created.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

}
