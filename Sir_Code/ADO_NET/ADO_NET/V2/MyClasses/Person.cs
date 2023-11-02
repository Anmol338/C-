using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.V2.MyClasses
{
    internal class Person
    {
        private int pid;
        private string fullName;
        private string contactAddress;

        public Person()
        {
            pid = 0;
            fullName = "";
            contactAddress = "";
        }

        public Person(int pid, string fullName, string contactAddress)
        {
            this.pid = pid;
            this.fullName = fullName;
            this.contactAddress = contactAddress;
        }

        public Person(Person person)
        {
            pid = person.pid;
            fullName = person.fullName;
            contactAddress = person.contactAddress;
        }

        public int PID
        {
            get { return pid; }
            set { pid = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string ContactAddress
        {
            get { return contactAddress; }
            set { contactAddress = value; }
        }

        override
        public string ToString()
        {
            return PID + ", " + FullName + ", " + ContactAddress;
        }
    }
}