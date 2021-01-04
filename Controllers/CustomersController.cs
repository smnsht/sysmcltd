using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sysmcltd.Models;

namespace sysmcltd.Controllers
{
    public class CustomersController : Controller
    {
        private readonly SysmcContext _context;

        public CustomersController(SysmcContext context)
        {
            _context = context;

            // seed data if needed
            if( _context.Customers.Count() == 0 )
            {
                sysmcltd.Migrations.Seed.Run(context);
            }
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var customers = await _context.Customers
                .Where(c => !c.IsDeleted)
                .ToListAsync();

            return View(customers);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.LoadCustomer((long)id);            

            if (customer == null)
            {
                return NotFound();
            }
            
            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsDeleted,Created,Name,CustomerNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.LoadCustomer((long)id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,IsDeleted,Created,Name,CustomerNumber")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            
            var customer = await _context.LoadCustomer((long)id);

            if (customer == null)
            {
                return NotFound();
            }

            foreach(var addr in customer.Addresses)
            {
                addr.IsDeleted = true;
            }

            foreach(var contact in customer.Contacts)
            {
                contact.IsDeleted = true;
            }

            customer.IsDeleted = true;
            
            await _context.SaveChangesAsync();
            
            TempData["AlertSuccess"] = "Customer successfully deleted!";
            
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(long id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }

        // related    

        [HttpPost]  
        public async Task<IActionResult> CreateCustomerContact(long id, [Bind("FullName", "OfficeNumber", "Email")] Contact contact)
        {
            if(ModelState.IsValid)
            {                
                contact.CustomerId = id;
                await _context.Contacts.AddAsync(contact);   
                await _context.SaveChangesAsync();

                TempData["AlertSuccess"] = "Contact successfully added!";

                return RedirectToAction(nameof(Edit), new { id = id });
            }            

            return View("Edit", await _context.LoadCustomer(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerAddress(long id, [Bind("City", "Street")] Address address)
        {
            if(ModelState.IsValid)
            {
                address.CustomerId = id;
                await _context.Addresses.AddAsync(address);
                await _context.SaveChangesAsync();

                TempData["AlertSuccess"] = "Contact successfully added!";

                return RedirectToAction(nameof(Edit), new { id = id });
            }

            return View("Edit", await _context.LoadCustomer(id));
        }

        [HttpGet]
        public IActionResult Exists(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return Json(false);
            }

            var b = _context.Customers
                .Where(c => c.Name.Contains(name))
                .Any();

            return Json(b);
        }
    }
}
