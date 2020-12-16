using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreTraining2020.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreTraining2020.Pages.modul06
{
    public class verschachteltModel : PageModel
    {
        private readonly ASPNETCoreTraining2020.Models.NordwindContext _context;

        public verschachteltModel(ASPNETCoreTraining2020.Models.NordwindContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public void  OnGet()
        {
       
          
            Customer =  _context.Customers.Include(o=>o.Orders).ToList();
        }
    }
}
