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
        public string MyProperty { get; set; }
        public  void OnGet([FromServices] IHttpClientFactory _client)
        {

            // var client = new HttpClient();

            CallMe( _client);

            //if (response.IsSuccessStatusCode)
            //{
             
            //}
            //else
            //{
              

            //}
           
        }
        public  void CallMe( IHttpClientFactory _client)
        {
            var http = _client.CreateClient();
            var req = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/modul07/langsam");

            var response = http.SendAsync(req).Result;

            MyProperty = response.StatusCode.ToString();

        }

    }
}
