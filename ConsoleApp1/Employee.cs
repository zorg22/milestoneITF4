using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Employee : Person
    {
        public Employee(string fname, string lname, Address address, int salary, Person supervisor, DateTime employmentStart, Job job) : base (fname, lname, address)
        {
            _fname = fname;
            _lname = lname;
            _address = address;
            _salary = salary;
            _supervisor = supervisor;
            _employmentStart = employmentStart;
            _job = job;
        }

        private string _fname;
        private string _lname;
        private Address _address;
        private int _salary;
        private Person _supervisor;
        private DateTime _employmentStart;
        private Job _job;

        public int Salary
        {
            get { return _salary; }
            private set
            {
                _salary = value;
            }
        }
        public Person Supervisor
        {
            get { return _supervisor; }
            private set
            {
                _supervisor = value;
            }
        }
        public DateTime EmploymentStart
        {
            get { return _employmentStart; }
            private set
            {
                _employmentStart = value;
            }
        }
        public Job Job
        {
            get { return _job; }
            private set
            {
                _job = value;
            }
        }
    }
}
