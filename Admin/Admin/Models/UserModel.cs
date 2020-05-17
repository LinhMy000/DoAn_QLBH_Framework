using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class User
    {
        public int id { set; get; }
        public string taiKhoan { set; get; }
        public string matKhau { set; get; }
        public string hoTen { set; get; }
        public bool tinhTrang { set; get; }
        public bool quyen { set; get; }
    }

    public class UsersContext : DbContext
    {
        private const string conString = "server=localhost; port=3306; database=quanlysach; uid=root; password=";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString);
        }

        public DbSet<User> User { set; get; }   // Bảng user trong DataBase, <User> tên lớp

        public User Find(int id)
        {
            using (var context = new UsersContext())
            {
                User user = new User();
                foreach (var i in context.User.ToList())
                {
                    if (i.id == id)
                    {
                        user.id = i.id;
                        user.taiKhoan = i.taiKhoan;
                        user.matKhau = i.matKhau;
                        user.hoTen = i.hoTen;
                        user.tinhTrang = i.tinhTrang;
                        user.quyen = i.quyen;
                        return user;
                    }
                }
            }
            return null;
        }
    }
}
