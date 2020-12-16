using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreTraining2020.Pages.modul05
{
    public class ThumbNailGen
    {

        public async Task Invoke(HttpContext context)
        {


        }
    }
    public static class ThumbNailGenExtensions
    {
        public static IApplicationBuilder UseThumbNailGen( IApplicationBuilder app)
        {
            return app.UseMiddleware<ThumbNailGen>();
        }
    }

}
