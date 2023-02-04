using _2019_2020cuoiky.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2019_2020cuoiky.Controllers
{
    public class CN_TCController : Controller
    {
        public IActionResult NhapSoTC()
        {
            return View();
        }

        public IActionResult LietKeTC(int soTC)
        {
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020cuoiky.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cachlycovid19;");
            ViewBag.listCNTC = context.LietKeTC(soTC);
            return View();
        }
    }
}
