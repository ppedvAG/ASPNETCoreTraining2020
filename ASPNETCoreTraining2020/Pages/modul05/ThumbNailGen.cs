using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace ASPNETCoreTraining2020.Pages.modul05
{
    public class ThumbNailGen
    {

        public async Task Invoke(HttpContext context)
        {
            var img = context.Request.Query["img"][0];
            var pfad = AppDomain.CurrentDomain.GetData("ImgDir") + @"\img\" + img;

            using (var fs = new FileStream(pfad, FileMode.Open))
            {

                using (var bild = new Bitmap(fs))
                {
                    var miniBild = new Bitmap(300, 200);
                    using (var graph = Graphics.FromImage(miniBild))
                    {
                        graph.DrawImage(bild, 0, 0, 300, 200);
                        var ms = new MemoryStream();
                        miniBild.Save(ms, ImageFormat.Jpeg);

                        await context.Response.Body.WriteAsync(ms.ToArray());

                    }



                }
            }
        }
    }
    public static class ThumbNailGenExtensions
    {
        public static IApplicationBuilder UseThumbNailGen(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ThumbNailGen>();
        }
    }

}
