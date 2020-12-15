using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreTraining2020.modul02;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.modul03
{
    public class page2Model : PageModel
    {
        Class1 class1;
        public page2Model(Class1 _class1)
        {
            class1 = _class1;
        }
        public int MyProperty { get; set; }
        public void OnGet()
        {
        }
        public string Datum()
        {
            return DateTime.Now.ToShortDateString();

        }
    }
}
