using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.Modul07
{
    public class AsyncProtoypModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync([FromServices] IHttpClientFactory _client)
        {

            // var client = new HttpClient();

            var http = _client.CreateClient();
            var req = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/modul07/langsam");

            var response = await http.SendAsync(req);



            if (response.IsSuccessStatusCode)
            {
             
            }
            else
            {
              

            }
            return Page();
        }
    }
}
