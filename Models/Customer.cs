using System;
using System.Collections.Generic;

namespace sysmcltd.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string CustomerNumber { get; set; }
        // has many
        public List<Address> Addresses { get; set; }
        public List<Contact> Contacts { get; set; }

        public Customer()
        {
            IsDeleted = false;
            Created = DateTime.Now;
            Addresses = new List<Address>();
            Contacts = new List<Contact>();
        }
    }
}