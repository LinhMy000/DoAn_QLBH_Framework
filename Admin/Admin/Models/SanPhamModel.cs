using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Admin.Models
{
    public class SanPham
    {
        public int? masp { set; get; }
        public string tensp { set; get; }
        public string loaisp { set; get; }
        public string thuongHieu { set; get; }
        public string nuocsx { set; get; }
        public string kichThuoc { set; get; }
        public string hinhAnh { set; get; }
        public double gia { set; get; }
        public string gioiTinh { set; get; }
        public int soLuong { set; get; }
        public string moTa { set; get; }
        public int? makm { set; get; }
    }

    public class SanPhamContext : DbContext
    {
        private const string conString = "server=localhost; port=3306; database=banquanao; uid=root; password=";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString);
        }

        public DbSet<SanPham> SanPhams { set; get; }   // Bảng sanpham trong DataBase

        public SanPham Find(int id)
        {
            using (var context = new SanPhamContext())
            {
                SanPham sp = new SanPham();
                foreach (var i in context.SanPhams.ToList())
                {
                    if (i.masp == id)
                    {
                        sp.masp = i.masp;
                        sp.tensp = i.tensp;
                        sp.loaisp = i.loaisp;
                        sp.thuongHieu = i.thuongHieu;
                        sp.nuocsx = i.nuocsx;
                        sp.kichThuoc = i.kichThuoc;
                        sp.hinhAnh = i.hinhAnh;
                        sp.gia = i.gia;
                        sp.gioiTinh = i.gioiTinh;
                        sp.soLuong = i.soLuong;
                        sp.moTa = i.moTa;
                        sp.makm = i.makm;
                        return sp;
                    }
                }
            }
            return null;
        }

        public int Create(SanPham i)
        {
            int row = 0;
            using (var context = new SanPhamContext())
            {
                context.SanPhams.Add(new SanPham
                {
                    masp = null,
                    tensp = i.tensp,
                    loaisp = i.loaisp,
                    thuongHieu = i.thuongHieu,
                    nuocsx = i.nuocsx,
                    kichThuoc = i.kichThuoc,
                    hinhAnh = i.hinhAnh,
                    gia = i.gia,
                    gioiTinh = i.gioiTinh,
                    soLuong = i.soLuong,
                    moTa = i.moTa,
                    makm = i.makm
                });
                row = context.SaveChanges();
                return row;
            }
        }

        public int Edit(SanPham i)
        {
            int row = 0;
            using(var context = new SanPhamContext())
            {
                var sp = context.SanPhams.Where(u => u.masp == i.masp).FirstOrDefault();
                if (sp != null)
                {
                    sp.tensp = i.tensp;
                    sp.loaisp = i.loaisp;
                    sp.thuongHieu = i.thuongHieu;
                    sp.nuocsx = i.nuocsx;
                    sp.kichThuoc = i.kichThuoc;
                    sp.hinhAnh = i.hinhAnh;
                    sp.gia = i.gia;
                    sp.gioiTinh = i.gioiTinh;
                    sp.soLuong = i.soLuong;
                    sp.moTa = i.moTa;
                    sp.makm = i.makm;
                    row = context.SaveChanges();
                }
            }
            return row;
        }

        public int Delete(int id)
        {
            int row = 0;
            SanPhamContext context = new SanPhamContext();
            SanPham sp = context.Find(id);
            if (sp != null)
            {
                context.Remove(sp);
                row = context.SaveChanges();
            }
            return row;
        }
    }
}
