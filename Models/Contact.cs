using System;
using System.ComponentModel.DataAnnotations;

namespace sysmcltd.Models
{
    public class Contact
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }

        [Required]
        public string FullName { get; set; }

        //[Phone]
        public string OfficeNumber { get; set; }

        //[EmailAddress]
        public string Email { get; set; }

        [Required]        
        public long CustomerId { get; set; }

        // belongs to
        //public Customer Customer { get; set; }

        public Contact()
        {
            IsDeleted = false;
            Created = DateTime.Now;
        }
    }
}