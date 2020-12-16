using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.Modul07
{
    public class langsamModel : PageModel
    {
        public void OnGet()
        {
            System.Threading.Thread.Sleep(5000);
        
        }
    }
}
