using System;

namespace sysmcltd.Models
{
    public class Address
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public long CustomerId { get; set; }
        // belongs to
        public Customer Customer { get; set; }

        public Address()
        {
            IsDeleted = false;
            Created = DateTime.Now;
        }
    }
}