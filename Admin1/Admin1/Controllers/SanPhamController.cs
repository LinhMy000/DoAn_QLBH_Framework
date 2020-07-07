using System.Collections.Generic;
using Admin1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin1.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            List<SanPham> list = SanPhamContext.GetSanPhams();
            return View(list);
        }

        public IActionResult Insert()
        {
            List<object> list = SanPhamContext.GetMakms();
            return View(list);
        }

        [HttpPost]
        public IActionResult Insert(SanPham sp)
        {
            int row = SanPhamContext.InsertSanPham(sp);
            if (row == 0)
                //return RedirectToAction(actionName: "ThongBao", controllerName: "Home");
                return RedirectToAction("Home/ThongBao");
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            SanPham sp = SanPhamContext.FindSanPham(id);
            return View(sp);
        }

        [HttpPost]
        public IActionResult Update(SanPham sp)
        {
            int row = SanPhamContext.UpdateSanPham(sp);
            if (row == 0)
                return RedirectToAction("Home/ThongBao");
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            int row = SanPhamContext.DeleteSanPham(id);
            if (row == 0)
                return RedirectToAction("Home/ThongBao");
            return RedirectToAction("Index");
        }
    }
}
