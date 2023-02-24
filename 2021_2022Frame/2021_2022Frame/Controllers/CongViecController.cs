using _2021_2022Frame.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2021_2022Frame.Controllers
{
    public class CongViecController : Controller
    {
        public IActionResult themcongviec()
        {
            return View();
        }
        public IActionResult themcv(congviec cv)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=quanlygara;");
            context.themcongviec(cv);
            return View("themcongviec");
        }
        public IActionResult xoacv(string Mabd, string Macv)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=quanlygara;");
            context.xoacongviec(Mabd, Macv);
            return View("/CongViec/chitietbaoduong");
        }
    }
}
