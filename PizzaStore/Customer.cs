using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Customer
    {
        //properties med get og set(skriv prop og tab 2 gange)
        public string Name { get; set; }
        public string Address { get; set; }
        public int TelephoneNo { get; set; }

        //konstruktør
        public Customer(string name, string address, int telephoneNo)
        {
            Name = name;
            Address = address;
            TelephoneNo = telephoneNo;
        }
        //tostring metode override
        public override string ToString()
        {
            return String.Format("Name:{0}, Number:{1}, Address:{2}", Name, TelephoneNo, Address);
        }
    }
}
