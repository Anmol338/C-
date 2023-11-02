using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    internal class Calculation
    {
        public Calculation(Data data) 
        { 
            data.Result = data.Num1 + data.Num2;
        }
    }
}
