using _2019_2020cuoiky.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2019_2020cuoiky.Controllers
{
    public class DiemCachLyController : Controller
    {
        public IActionResult NhapDCL()
        {
            return View();
        }

        public IActionResult ThemDCL(DiemCachLy dcl)
        {
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020cuoiky.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cachlycovid19;");
            context.ThemDCL(dcl);
            return View("NhapDCL");
        }

        public IActionResult LietKeDCL()
        {
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020cuoiky.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cachlycovid19;");
            ViewBag.listDCL = context.getAllDCL();
            return View();
        }
    }
}
