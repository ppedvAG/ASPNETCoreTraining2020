using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.modul05
{
    public class BildUploadModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(IFormFile datei)
        {
         
            var pfad = AppDomain.CurrentDomain.GetData("ImgDir") + @"\img\" + datei.FileName;
            using (var fs = new FileStream(pfad, FileMode.Create))
            {
                datei.CopyTo(fs);
            }
            
        }
    }
}
