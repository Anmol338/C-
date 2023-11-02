using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI
{
    internal class CUI
    {
        private int num1, num2;
        public CUI()
        {
            Console.WriteLine("Enter the first number : ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second number : ");
            num2 = Int32.Parse(Console.ReadLine());
        }

    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            new CUI();
        }
    }
}
