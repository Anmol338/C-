using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.File_Handling
{
    internal class AvgNum
    {

        private int sum = 0, count = 0, average = 0;

        public int CalculateAvgNumber(ArrayList array)
        {
            try
            {
                if (array.Count != 0)
                {
                    foreach (int item in array)
                    {
                        sum += item;
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Error : ArrayList is Empty");
                }

                average = sum / count;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return average;

        }
    }
}
