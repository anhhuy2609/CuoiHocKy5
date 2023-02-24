using _2021_2022Frame.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2021_2022Frame.Controllers
{
    public class BaoDuongController : Controller
    {
        public IActionResult chonsoxe()
        {
            return View();
        }

        public IActionResult lietkesuachua(string soxe)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=quanlygara;");
            ViewBag.listBD = context.getbaoduong(soxe);
            return View();
        }

        public IActionResult chitietbaoduong(string Mabd)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=quanlygara;");
            ViewBag.CTBD = context.chitietbaoduong(Mabd);
            ViewBag.listCV = context.getcongviec(Mabd);
            return View();
        }
        public IActionResult suabaoduong(string Mabd)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=quanlygara;");
            ViewBag.baoduong = context.suabaoduong(Mabd);
            return View();
        }
        public IActionResult capnhatbd(baoduong baoduong)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=quanlygara;");
            context.capnhatbd(baoduong);
            return View("lietkesuachua");
        }
    }
}
