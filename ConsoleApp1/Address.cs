using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Address
    {
        public Address(string street, string flatNumber, string city)
        {
            _street = street;
            _flat = flatNumber;
            _city = city;
        }

        private string _street;
        private string _flat;
        private string _city;

        public string Street
        {
            get { return _street; }
            private set
            {
                _street = value;
            }
        }
        public string Flat
        {
            get { return _flat; }
            private set
            {
                _flat = value;
            }
        }
        public string City
        {
            get { return _city; }
            private set
            {
                _city = value;
            }
        }
    }
}
