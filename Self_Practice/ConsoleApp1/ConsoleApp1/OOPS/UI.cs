using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    internal class UI
    {
        public UI()
        {
            Data data = new Data();
            Console.WriteLine("Enter the first number : ");
            data.Num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            data.Num2 = Int32.Parse(Console.ReadLine());
            new Calculation(data);
            Console.WriteLine("The sum of " + data.Num1 + " + " + data.Num2 + " = " + data.Result);
        }
    }

}
