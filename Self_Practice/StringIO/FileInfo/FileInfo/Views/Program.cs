using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfo.Views
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a File
            /*FileCreate fc = new FileCreate();*/

            // Write content in the File
            WriteIntoFile wf = new WriteIntoFile();

            // Read a content from the File
            ReadFile rf = new ReadFile();
        }
    }
}
