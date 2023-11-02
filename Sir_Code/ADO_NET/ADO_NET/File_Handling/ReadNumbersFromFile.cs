using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.File_Handling
{
    internal class ReadNumbersFromFile
    {

        ArrayList fnums = new ArrayList();
        string filaPath = "D:\\C#\\Documents\\try.txt";
        string num;
        int sum = 0;

        public ArrayList readFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filaPath))
                {
                    while ((num = sr.ReadLine()) != null)
                    {
                        fnums.Add(int.Parse(num));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return fnums;

        }
    }

}
