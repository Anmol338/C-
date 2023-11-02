using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    internal class Data
    {
        public int num1 = 0;
        public int num2 = 0;
        public int result = 0;

        public void data(int x, int y)
        {
            this.num1 = x;
            this.num2 = y;
        }

        public int Num1
        {
            get 
            { 
                return num1; 
            }

            set
            {
                num1 = value;
            }
        }

        public int Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        public int Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

    }
}
