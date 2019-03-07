using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class Customer : Person
    {
        public Customer(string fname, string lname, Address address, int booksPurchased) : base (fname, lname, address)
        {
            _fname = fname;
            _lname = lname;
            _address = address;
            _booksPurchased = booksPurchased;
        }

        private string _fname;
        private string _lname;
        private Address _address;
        private int _booksPurchased;
    }
}
