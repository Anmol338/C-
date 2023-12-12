using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1_2133112.Data
{

    internal class DetailsMw
    {
        private int pid;
        private string details;
        private string beginDate;
        private string beginTime;

        public DetailsMw()
        {
            pid = 0;
            details = "";
            beginDate = "";
            beginTime = "";
        }

        public DetailsMw(int pid, string details, string beginDate, string beginTime)
        {
            this.pid = pid;
            this.details = details;
            this.beginDate = beginDate;
            this.beginTime = beginTime;
        }

        public DetailsMw(DetailsMw detailsmw)
        {
            pid = detailsmw.pid;
            details = detailsmw.details;
            beginDate = detailsmw.beginDate;
            beginTime = detailsmw.beginTime;
        }

        public int PID
        {
            get { return pid; }
            set { pid = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        public string Begin_Date
        {
            get { return beginDate; }
            set { beginDate = value; }
        }

        public string Begin_Time
        {
            get { return beginTime; }
            set { beginTime = value; }

        }

        override
        public string ToString()
        {
            return PID + ", " + Details + ", " + Begin_Date + " , " + Begin_Time;
        }
    }
}
