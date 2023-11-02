using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.File_Handling
{
    internal class MinNum
    {

        private int min = 0;

        public int CalculateMinNumber(ArrayList array)
        {
            try
            {
                if (array.Count != 0)
                {

                    min = int.Parse(array[0].ToString());

                    foreach (int item in array)
                    {
                        min = Math.Min(min, item);
                    }
                }
                else
                {
                    MessageBox.Show("Error : ArrayList is Empty");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return min;
        }
    }
}
