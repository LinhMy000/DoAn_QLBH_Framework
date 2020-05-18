using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new UsersContext())
            {
                var listUser = context.User.ToList();   //Lấy List student từ DB
                return View(listUser);
            }
        }

        public ActionResult Edit(int id)
        {
            UsersContext context = new UsersContext();
            User user = context.Find(id);
            if (user == null)
            {
                return View();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User model)
        {
            using (var context = new UsersContext())
            {
                //Dùng cú pháp method LINQ
                var x = context.User.Where(u => u.id == model.id).FirstOrDefault();
                if (x != null)
                {
                    x.taiKhoan = model.taiKhoan;
                    x.matKhau = model.matKhau;
                    x.hoTen = model.hoTen;
                    x.tinhTrang = model.tinhTrang;
                    x.quyen = model.quyen;
                    context.SaveChanges();
                    //return RedirectToRoute(new { controller = "User", action = "Index" });
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User model)
        {
            using (var context = new UsersContext())
            {
                context.User.Add(new User
                {
                    id = null,
                    taiKhoan = model.taiKhoan,
                    matKhau = model.matKhau,
                    hoTen = model.hoTen,
                    tinhTrang = model.tinhTrang,
                    quyen = model.quyen
                });
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            UsersContext context = new UsersContext();
            User user = context.Find(id);
            if (user != null)
            {
                context.Remove(user);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}