using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new SanPhamContext())
            {
                return View(context.SanPhams.ToList());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SanPham model)
        {
            using (var context = new SanPhamContext())
            {
                int row = context.Create(model);
                if (row != 0)
                    return RedirectToAction("Index");
                else
                    return View("Không thành công!");
            }
        }

        public ActionResult Edit(int id)
        {
            using (var context = new SanPhamContext())
            {
                return View(context.Find(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SanPham model)
        {
            using (var context = new SanPhamContext())
            {
                int row = context.Edit(model);
                if (row != 0)
                    return RedirectToAction("Index");
                else
                    return View("Không thành công!");
            }
        }

        public ActionResult Delete(int id)
        {
            using (var context = new SanPhamContext())
            {
                context.Delete(id);
                return RedirectToAction("Index");
            }
        }

    }
}