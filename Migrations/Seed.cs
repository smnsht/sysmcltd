using sysmcltd.Models;

namespace sysmcltd.Migrations
{
    public class Seed
    {
        public static void Run(SysmcContext ctx)
        {
            ctx.Customers.AddRange(GetCustomers());
            ctx.SaveChanges();

            ctx.Addresses.AddRange(GetAddresses());
            ctx.SaveChanges();

            ctx.Contacts.AddRange(GetContacts());
            ctx.SaveChanges();            
        }

        private static Customer [] GetCustomers()
        {
            return new Customer[]
            {
                new Customer() { Name = "Gary Oldman", CustomerNumber = "309642772" },
                new Customer() { Name = "Bradd Pitt", CustomerNumber = "309642773" },
                new Customer() { Name = "Quentin Tarantino", CustomerNumber = "309642774" }
            };
        }       

        private static Address [] GetAddresses()
        {
            return new Address[]
            {
                new Address() { CustomerId = 1, City = "Los Angeles", Street = "Sum Sum street" },
                new Address() { CustomerId = 2, City = "Las Vegas", Street = "Main street" },
                new Address() { CustomerId = 3, City = "New York City", Street = "Main Avenue" }
            };
        }

        private static Contact [] GetContacts()
        {
            return new Contact[]
            {
                new Contact() { CustomerId = 1, FullName = "Oldman Gary", Email = "111111@domain.com", OfficeNumber = "11111111"},
                new Contact() { CustomerId = 2, FullName = "Pitt Bradd", Email = "22222@domain.com", OfficeNumber = "22222"},
                new Contact() { CustomerId = 3, FullName = "Tarantin Quentini", Email = "3333333@domain.com", OfficeNumber = "3333333"},
            };
        }
    }
}