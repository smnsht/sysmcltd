using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace sysmcltd.Models
{
    public class SysmcContext : DbContext
    {
        public SysmcContext (DbContextOptions<SysmcContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public async Task<Customer> LoadCustomer(long id)
        {
            var customer = await Customers.FirstOrDefaultAsync(m => m.Id == id && !m.IsDeleted);

            if(customer != null)
            {
                customer.Contacts = await Contacts
                    .Where(c => c.CustomerId == id && !c.IsDeleted)
                    .ToListAsync<Contact>();

            customer.Addresses = await Addresses
                .Where(a => a.CustomerId == id && !a.IsDeleted)
                .ToListAsync<Address>();
            }

            return customer;
        }
    }
}