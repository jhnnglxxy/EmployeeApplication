using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace

{
    internal class Employee
    {
        private long employeeid;
        private string fname;
        private string lname;
        private string empposition;

        public Employee()
        {
            this.employeeid = 0;
            this.fname = " ";
            this.lname = " ";
            this.empposition = " ";

        }

        public Employee(long employeeid, string fname, string lname, string empposition)
        {
            this.employeeid = employeeid;
            this.fname = fname;
            this.lname = lname;
            this.empposition = empposition;
        }

        public long employeeId
        {
            get
            {
                return this.employeeid;
            }
            set
            {
                this.employeeid = value;
            }
        }

        public string empFname
        {
            get
            {
                return this.fname;
            }
            set
            {
                this.lname = value;
            }
        }

        public string empLname
        {
            get
            {
                return this.lname;
            }
            set
            {
                this.lname = value;
            }
        }

        public string empPosition
        {
            get
            {
                return this.empposition;
            }
            set
            {
                this.empposition = value;
            }
        }
    }
}