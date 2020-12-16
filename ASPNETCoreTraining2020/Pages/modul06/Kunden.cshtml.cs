using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreTraining2020.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.modul06
{
    public class KundenModel : PageModel
    {
        public void OnGet()
        {
            var db = new NordwindContext();
            var kunden = db.Customers.Where(x=>x.CompanyName.Contains("e"));

        }
    }
}
