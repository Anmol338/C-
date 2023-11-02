using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.W2
{
    internal class Program1
    {
        public void f1(int x, int y)
        {
            x++;
            y++;
            Console.WriteLine(x + y);
        }
        //variables
        //constructors
        //setters
        //getters
        //toString
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello from Program1 !!");
            //new Program1().f1(4, 5);
            //Program1 program1 = new Program1();
            //program1.f1(1, 2);

            int num1, num2;
            Console.Write("Enter first number : ");
            String tmp = Console.ReadLine();
            num1 = Int32.Parse(tmp);    //String to int (type conversion)
            Console.Write("Enter second number : ");
            tmp = Console.ReadLine();
            num2 = Int32.Parse(tmp);    //String to int (type conversion)
            new Program1().f1(num1, num2);
        }
    }
}
