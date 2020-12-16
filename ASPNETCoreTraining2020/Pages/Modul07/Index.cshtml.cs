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
    public class IndexModel : PageModel
    {
        private readonly ASPNETCoreTraining2020.Models.NordwindContext _context;

        public IndexModel(ASPNETCoreTraining2020.Models.NordwindContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
