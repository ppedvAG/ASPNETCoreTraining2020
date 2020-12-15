using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.modul03
{
    public class RequestCounterModel : PageModel
    {
       
        public void OnGet([FromServices] MyCounter myCounter)
        {
            myCounter.Wert++;
           
        }
    }
}
