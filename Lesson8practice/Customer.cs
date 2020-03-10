using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8practice
{
    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Membership membership;

        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            membership = new Membership();
        }
    }
}
