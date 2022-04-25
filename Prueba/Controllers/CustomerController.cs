using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Test_InvoiceContext _context;
        public CustomerController(Test_InvoiceContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() => View(await _context.Customers.ToListAsync());
        public async Task<IActionResult> Create() => View();
    }
}
