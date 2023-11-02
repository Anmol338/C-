using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore.W3
{
    internal class DataTypes
    {
        enum Days {SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY};

        struct Book
        {
            public string title; // must be public
            public int pages;   // must be public
        };

        public DataTypes()
        {
            //1. basic types -system defined (Pass by Value)
            // bool, char
            bool result = false;
            Console.WriteLine(result);

            char character = 'A';
            Console.WriteLine(character);

            //byte, short, int, long (sbyte, ushort, uint, ulong)
            byte num = 100;
            Console.WriteLine(num);

            sbyte num1 = -100;
            Console.WriteLine(num1);

            short num3 = -1000;
            Console.WriteLine(num3);

            ushort num4 = 1000;
            Console.WriteLine(num4);

            int num5 = -10000;
            Console.WriteLine(num5);

            uint num6 = 10000;
            Console.WriteLine(num6);

            long num7 = -100000;
            Console.WriteLine(num7);

            ulong num8 = 100000;
            Console.WriteLine(num8);

            //float, double, decimal

            //2. basic types - user defined (Pass by Value)
            //a. enum 
            Days day1 = Days.SUNDAY; //SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
            Console.WriteLine(day1);
            day1 = Days.TUESDAY;
            Console.WriteLine(day1);

            //b. struct
            Book book1;
            book1 = new Book();
            book1.title = "Introduction to C#";
            book1.pages = 1345;
            Console.WriteLine(book1.title + ", " + book1.pages);
        }

    }

    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            new DataTypes();
        }
    }
    */
}
