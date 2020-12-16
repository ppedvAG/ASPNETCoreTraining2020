using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreTraining2020.Pages.Modul07
{
    public class TodoAufrufModel : PageModel
    {
        public List<Aufgabe> AufgabenListe { get; set; }
        public async Task<IActionResult> OnGetAsync([FromServices] IHttpClientFactory _client,
            [FromQuery]string suche)
        {

            // var client = new HttpClient();

            var http = _client.CreateClient();
            var req = new HttpRequestMessage(HttpMethod.Get, $"https://jsonplaceholder.typicode.com/todos?userId={suche}");
            //req.Headers.Accept.Add("application/json");
            req.Headers.Add("Accept", "application/json");

            var response = await http.SendAsync(req) ;
         


            if (response.IsSuccessStatusCode)
            {
                var s =await response.Content.ReadAsStringAsync();
                AufgabenListe = JsonSerializer.Deserialize<List<Aufgabe>>(s);
            }
            else
            {
                AufgabenListe = new List<Aufgabe>();

            }
            return Page();
        }
    }
}
