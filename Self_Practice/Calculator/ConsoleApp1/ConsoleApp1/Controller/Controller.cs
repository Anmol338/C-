using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    internal class Controller
    {
        public class Data
        {
            private int num1 = 0;
            private int num2 = 0;
            private int result = 0;

            public void Num1(int num1)
            {
                this.num1 = num1;
            }

            public void Num2(int  num2) 
            { 
                this.num2 = num2;
            }

            public void Result(int result)
            {
                this.result = result;
            }
        }
    }
}
