using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FileDownloader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public  ActionResult DownloadFile(string url, string fileName)
        {
            const string download = "downloads";
            var path = ControllerContext.HttpContext.Server.MapPath(@"~/"+ download + "/"+ fileName);

           var downloadPath= $"{Request.Url.Scheme}://{Request.Url.Authority}{Url.Content("~")}//{download}//{fileName}";


            using (var wc = new WebClient())
            {
                wc.Headers.Add("user-agent", "Only a test!");
                wc.DownloadFile(
                    // Param1 = Link of file
                    new System.Uri(url),
                    // Param2 = Path to save
                    path
                );
            }

            return Content($"<a href='{downloadPath}'>fileName</a>");
        }
 
    }
}