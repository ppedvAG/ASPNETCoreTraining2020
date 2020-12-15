using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.modul03
{
    public class Calc2Model : PageModel
    {
        
        public int Ergebnis { get; set; } = 0;
        public int Feld;
        public void OnGet()
        {
      
        }
        public void OnPostAdd()
        {
         
            int a, b = 0;
            int.TryParse(Request.Form["eins"].FirstOrDefault(), out a);
            int.TryParse(Request.Form["zwei"].FirstOrDefault(), out b);
            Ergebnis = a + b;
 
        }
        public void OnPostSub()
        {

            int a, b = 0;
            int.TryParse(Request.Form["eins"].FirstOrDefault(), out a);
            int.TryParse(Request.Form["zwei"].FirstOrDefault(), out b);
            Ergebnis = a - b;

        }
    }
}
