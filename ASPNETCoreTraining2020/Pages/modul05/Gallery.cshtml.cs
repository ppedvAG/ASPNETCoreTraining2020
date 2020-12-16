using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.modul05
{
    public class GalleryModel : PageModel
    {
        public string[] BildListe { get; set; }
        public void OnGet()
        {
            var pfad = AppDomain.CurrentDomain.GetData("ImgDir") + @"\img\" ;
            BildListe = Directory.GetFiles(pfad);
        }
    }
}
