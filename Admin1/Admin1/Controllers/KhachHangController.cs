using System.Collections.Generic;
using Admin1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin1.Controllers
{
    public class KhachHangController : Controller
    {
        public IActionResult Index()
        {
            List<KhachHang> list = KhachHangContext.GetKhachHangs();
            return View(list);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(KhachHang kh)
        {
            KhachHangContext.InsertTaiKhoan(kh);
            return RedirectToAction("Index");
        }

        public IActionResult Them()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Them(KhachHang kh)
        {
            KhachHangContext.InsertTaiKhoan(kh);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            KhachHang kh = KhachHangContext.FindKhachHang(id);
            return View(kh);
        }

        [HttpPost]
        public IActionResult Update(KhachHang kh)
        {
            KhachHangContext.UpdateKhachHang(kh);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            KhachHangContext.DeleteKhachHang(id);
            return RedirectToAction("Index");
        }
    }
}
