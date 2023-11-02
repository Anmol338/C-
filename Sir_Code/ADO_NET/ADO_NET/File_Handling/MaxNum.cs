using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.File_Handling
{
    internal class MaxNum
    {

        private int max = 0;

        public int CalculateMaxNumber(ArrayList array)
        {
            try
            {
                if (array.Count != 0)
                {
                    foreach (int item in array)
                    {
                        max = Math.Max(max, item);
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

            return max;
        }
    }
}
