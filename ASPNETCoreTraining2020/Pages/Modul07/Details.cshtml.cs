using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNETCoreTraining2020.Models;

namespace ASPNETCoreTraining2020.Pages.Modul07
{
    public class DetailsModel : PageModel
    {
        private readonly ASPNETCoreTraining2020.Models.NordwindContext _context;

        public DetailsModel(ASPNETCoreTraining2020.Models.NordwindContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
