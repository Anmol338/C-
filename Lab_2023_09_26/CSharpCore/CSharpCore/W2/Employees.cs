using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore.W2
{
    internal class Employees
    {

    }

    public class Employee
    {
        public string name;
        public int age;
        public string position;
        public Employee( string n, int a, string p)
        {
            name = n;
            age = a;
            position = p;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Anmol", 21, "HRD");
            Console.WriteLine(emp.name+ " " + emp.age + " " + " " +emp.position);
        }
    }
}
