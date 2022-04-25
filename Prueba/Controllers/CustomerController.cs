using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;
using Prueba.Models.ViewModels;

namespace Prueba.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Test_InvoiceContext _context;
        public CustomerController(Test_InvoiceContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() => View(await _context.Customers.Where(x => x.Status == true).Include(x => x.CustomerType).ToListAsync());

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var customerCreation = new CustomerCreation();
            customerCreation.CustomerTypes = await _context.CustomerTypes.Select(x => new SelectListItem() { Text = x.Description, Value = x.Id.ToString() }).ToListAsync();
            return View(customerCreation);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreation customerCreation)
        {
            _context.Customers.Add(customerCreation.Customer);
            await _context.SaveChangesAsync();
            return await Index();
        }
    }
}
