using _2019_2020cuoiky.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2019_2020cuoiky.Controllers
{
    public class CongNhanController : Controller
    {
        public IActionResult ListCN(string MaDiemCachLy)
        {
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020cuoiky.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cachlycovid19;");
            ViewBag.listCN = context.getCongNhan(MaDiemCachLy);
            return View();
        }

        public IActionResult deleteCN(string MaCongNhan)
        {
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020cuoiky.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cachlycovid19;");
            context.deleteCN(MaCongNhan);
            return View("ListCN");
        }

        [Route("/CongNhan/ViewCN/{MaCongNhan}")]
        public IActionResult viewCN(string MaCongNhan)
        {
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(_2019_2020cuoiky.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cachlycovid19;");
            return View(ViewBag.CongNhan = context.getCNInfo(MaCongNhan));
        }
    }
}
