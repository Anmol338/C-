using System;

namespace TechBeamers
{
    abstract class BaseClass
    {
        public int i;

        // Abstract method to be implemented by derived classes
        public abstract void Print();
    }

    class Derived : BaseClass
    {
        public int j;
        public int val;

        // Implementation of the abstract method
        public override void Print()
        {
            val = i + j;
            Console.WriteLine($"i: {i}\nj: {j}\nSum is: {val}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Derived using BaseClass reference
            BaseClass obj = new Derived();
            obj.i = 2;

            // Creating an instance of Derived using Derived reference
            Derived obj1 = new Derived();
            obj1.j = 10;

            // Calling the Print method through the BaseClass reference
            obj.Print();

            Console.ReadLine();
        }
    }
}