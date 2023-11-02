using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore.W3
{
    internal class ReferenceType
    {
        public ReferenceType()
        {
            
        }

    }

    public class Student
    {
        public int sid;
        public string name;
    }

    interface Inf1
    {
        void f1(); //abstract method
    }

    public class Class1 : Inf1
    {
        //Must override abstract method of Inf1
        public void f1()
        {
            Console.WriteLine("Hello from f1() of Class1.");
        }
    }

    public class Class2 : Inf1
    {
        public void f1()
        {
            Console.WriteLine("Hello from f1() of Class2.");
        }
    }

    public delegate int DelegateFunction(int x, int y);

    internal class DelegateTest
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Diff(int x, int y)
        {
            return x - y;
        }

        public int prd(int x, int y)
        {
            return x * y;
        }
    }

    public class OldStudent
    {
        public int sid;
        public string name;

        public OldStudent(int sid, string name)
        {
            this.sid = sid;
            this.name = name;
        }
    }

    // Converting record in class for value comparison
    public record class NewStudent
    {
        public int sid
        {
            get;
            set;
        } = default;

        public string name
        {
            get;
            set;
        } = default;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Defined Reference Type (Class, Interface, Delegate, Record)
            // Class

            /*new ReferenceType();
            Student s1 = new Student();
            s1.sid = 1;
            s1.name = "Raj Sharma";
            Console.WriteLine(s1.sid + ", " + s1.name);*/




            // Interface

           /* new Class1().f1();
            new Class2().f1();*/




            // Delegate

            /*DelegateFunction test = new DelegateTest().Sum;
            int num1 = 5;
            int num2 = 10;
            int result = test(num1, num2);
            Console.WriteLine("The sum of " + num1 + " + " + num2 + " = " + result + ".");

            test = new DelegateTest().Diff;
            result = test(10, 5);
            Console.WriteLine("The difference of " + num1 + " - " + num2 + " = " + result + ".");

            test = new DelegateTest().prd;
            result = test(10, 5);
            Console.WriteLine("The product of " + num1 + " * " + num2 + " = " + result + ".");*/




            //Record
            // Call by reference

            /*OldStudent s01 = new OldStudent(1, "Raj");
            OldStudent s02 = new OldStudent(1, "Raj");
            bool result = (s01 == s02);
            Console.WriteLine(result);*/



            // ================================================================================= //
            // Call by value
            /*NewStudent ns1 = new NewStudent();
            NewStudent ns2 = new NewStudent();

            ns1.sid = 1;
            ns2.sid = 1;

            ns1.name = "Sharma";
            ns2.name = "Sharma";

            bool result = (ns1 == ns2);
            Console.WriteLine(result);*/



            unsafe
            {
                int num1 = 5;
                int* p1;
                p1 = &num1;
                Console.WriteLine(*p1);
                Console.WriteLine((int)p1);
                Console.WriteLine((int)&num1);
            }


        }
    }
}
