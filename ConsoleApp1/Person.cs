using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Person
    {
        public Person(string fname, string lname, Address address)
        {
            _fname = fname;
            _lname = lname;
            _address = address;
        }

        private string _fname;
        private string _lname;
        private Address _address;

        public string FirstName
        {
            get { return _fname; }
            private set
            {
                _fname = value;
            }
        }
        public string LastName
        {
            get { return _lname; }
            private set
            {
                _lname = value;
            }
        }
        public Address Address
        {
            get { return _address; }
            private set
            {
                _address = value;
            }
        }
    }
}
