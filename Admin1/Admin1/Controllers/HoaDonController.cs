using System.Collections.Generic;
using Admin1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin1.Controllers
{
    public class HoaDonController : Controller
    {
        public IActionResult Index()
        {
            List<HoaDon> list = HoaDonContext.GetHoaDons();
            return View(list);
        }

        public IActionResult Update(int id)
        {
            HoaDon kh = HoaDonContext.FindHoaDon(id);
            return View(kh);
        }

        [HttpPost]
        public IActionResult Update(HoaDon kh)
        {
            HoaDonContext.UpdateHoaDon(kh);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            HoaDonContext.DeleteHoaDon(id);
            return RedirectToAction("Index");
        }
    }
}
