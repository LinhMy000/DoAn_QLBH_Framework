using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Admin1.Models;
using System;
using System.Collections.Generic;

namespace Admin1.Controllers
{
    public class ThongKeController : Controller
    {
        private readonly ILogger<ThongKeController> _logger;

        public ThongKeController(ILogger<ThongKeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoanhThu()
        {
            List<object> list = ThongKeModel.DoanhThu();
            return View(list);
        }

        public IActionResult TopSanPham()
        {
            List<object> list = ThongKeModel.TopSanPham();
            return View(list);
        }

        public IActionResult TopKhachHang()
        {
            List<object> list = ThongKeModel.TopKhachHang();
            return View(list);
        }

        public IActionResult KhachHang()
        {
            List<object> list = ThongKeModel.KhachHang();
            return View(list);
        }
    }
}
