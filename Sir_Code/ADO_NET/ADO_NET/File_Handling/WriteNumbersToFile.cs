using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.File_Handling
{
    internal class WriteNumbersToFile
    {
        public void writeIntoFile(ArrayList numbers)
        {
            String filepath = "D:\\C#\\Documents\\try.txt";
            try
            {
                // Create or overwrite the file
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (int number in numbers)
                    {
                        // Write each number in new line of file
                        writer.WriteLine(number);
                    }
                }
                MessageBox.Show("Success : Data has been successfully copy to the file.");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
        }
    }
}
