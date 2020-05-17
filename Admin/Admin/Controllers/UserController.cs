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
    }
}