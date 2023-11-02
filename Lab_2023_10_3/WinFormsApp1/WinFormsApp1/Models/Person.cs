using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1.Models
{
    internal class Person
    {
        // Variables Declarable
        private int pid;
        private string fullname;
        private string address;
        private string age;
        private string gender;

        // Default Constructor
        public Person()
        {
            this.pid = 0;
            this.fullname = "";
            this.address = "";
            this.age = "";
            this.gender = "";
        }

        // Parametarized Constructor
        public Person(int pid, string fullname, string address, string age, string gender)
        {
            this.pid = pid;
            this.fullname = fullname;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        // Copy Constructor
        public Person(Person person)
        {
            this.pid = person.pid;
            this.fullname = person.fullname;
            this.address = person.address;
            this.age = person.age;
            this.gender = person.gender;
        }

        // Setters & Getters
        public int PID 
        { 
            get 
            { 
                return this.pid; 
            }
            set 
            {  
                this.pid = value;
            }
        }

        public string FullName
        {
            get 
            {
                return this.fullname; 
            }

            set
            {
                this.fullname = value;
            }
        }

        public string Address
        {
            get 
            { 
                return this.address; 
            }

            set 
            { 
                this.address = value; 
            }
        }

        public string Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }
        }

        override
        public string ToString()
        {
            return this.pid + ", " + this.fullname + ", " + this.address + ", " + this.age + ", " + this.gender;
        }
    }
}
