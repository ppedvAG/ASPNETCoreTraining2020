using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.modul04
{
    public class ExcelExportModel : PageModel
    {
        public void OnGet()
        {
        }
        public PartialViewResult OnGetExport()
        { 
            HttpContext.Response.Headers.Add("content-disposition", "attachment; filename=export.xlsx" );
            HttpContext.Response.ContentType = "application/vnd.ms-excel";
            return Partial("_excel");
        }
    }
}
