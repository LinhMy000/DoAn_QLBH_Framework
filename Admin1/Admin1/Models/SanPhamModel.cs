using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Admin1.Models
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
        public int makm { set; get; }
        /*
        public SanPham()
        {
            masp = null;
            tensp = null;
            loaisp = null;
            thuongHieu = null;
            nuocsx = null;
            kichThuoc = null;
            hinhAnh = null;
            gia = 0;
            gioiTinh = null;
            soLuong = 0;
            moTa = null;
            makm = 0;
        }
        */
    }

    public class SanPhamContext
    {
        private static MySqlConnection con = Connection.GetConnection();

        public static List<SanPham> GetSanPhams()
        {
            con.Open();
            List<SanPham> list = new List<SanPham>();
            string sql = "select * from sanpham";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new SanPham()
                    {
                        masp = reader.GetInt16(0),
                        tensp = reader[1].ToString(),
                        loaisp = reader[2].ToString(),
                        thuongHieu = reader[3].ToString(),
                        nuocsx = reader[4].ToString(),
                        kichThuoc = reader[5].ToString(),
                        hinhAnh = reader[6].ToString(),
                        gia = reader.GetDouble(7),
                        gioiTinh = reader[8].ToString(),
                        soLuong = reader.GetInt16(9),
                        moTa = reader[10].ToString(),
                        makm = reader.GetInt16(11)
                    });
                }
                reader.Close();
            }
            con.Close();
            return list;
        }

        public static int InsertSanPham(SanPham sp)
        {
            con.Open();
            string sql = "insert into sanpham values(@masp, @tensp, @loaisp, @thuonghieu, @nuocsx, @kichthuoc, @hinhanh, @gia, @gioitinh, @soluong, @mota, @makm)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("masp", sp.masp);
            cmd.Parameters.AddWithValue("tensp", sp.tensp);
            cmd.Parameters.AddWithValue("loaisp", sp.loaisp);
            cmd.Parameters.AddWithValue("thuonghieu", sp.thuongHieu);
            cmd.Parameters.AddWithValue("nuocsx", sp.nuocsx);
            cmd.Parameters.AddWithValue("kichthuoc", sp.kichThuoc);
            cmd.Parameters.AddWithValue("hinhanh", sp.hinhAnh);
            cmd.Parameters.AddWithValue("gia", sp.gia);
            cmd.Parameters.AddWithValue("gioitinh", sp.gioiTinh);
            cmd.Parameters.AddWithValue("soluong", sp.soLuong);
            cmd.Parameters.AddWithValue("mota", sp.moTa);
            cmd.Parameters.AddWithValue("makm", sp.makm);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static int UpdateSanPham(SanPham sp)
        {
            con.Open();
            string sql = "update sanpham set tensp=@tensp, loaisp=@loaisp, thuonghieu=@thuonghieu, nuocsx=@nuocsx, kichthuoc=@kichthuoc, hinhanh=@hinhanh, gia=@gia, gioitinh=@gioitinh, soluong=@soluong, mota=@mota, makm=@makm where masp=@masp";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("tensp", sp.tensp);
            cmd.Parameters.AddWithValue("loaisp", sp.loaisp);
            cmd.Parameters.AddWithValue("thuonghieu", sp.thuongHieu);
            cmd.Parameters.AddWithValue("nuocsx", sp.nuocsx);
            cmd.Parameters.AddWithValue("kichthuoc", sp.kichThuoc);
            cmd.Parameters.AddWithValue("hinhanh", sp.hinhAnh);
            cmd.Parameters.AddWithValue("gia", sp.gia);
            cmd.Parameters.AddWithValue("gioitinh", sp.gioiTinh);
            cmd.Parameters.AddWithValue("soluong", sp.soLuong);
            cmd.Parameters.AddWithValue("mota", sp.moTa);
            cmd.Parameters.AddWithValue("makm", sp.makm);
            cmd.Parameters.AddWithValue("masp", sp.masp);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static int DeleteSanPham(int id)
        {
            con.Open();
            string sql = "delete from sanpham where masp=@masp";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("masp", id);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static SanPham FindSanPham(int id)
        {
            con.Open();
            SanPham sp = new SanPham();
            string sql = "select * from sanpham where masp=@masp";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("masp", id);
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                sp.masp = reader.GetInt16("masp");
                sp.tensp = reader["tensp"].ToString();
                sp.loaisp = reader["loaisp"].ToString();
                sp.thuongHieu = reader["thuonghieu"].ToString();
                sp.nuocsx = reader["nuocsx"].ToString();
                sp.kichThuoc = reader["kichthuoc"].ToString();
                sp.hinhAnh = reader["hinhanh"].ToString();
                sp.gia = reader.GetDouble("gia");
                sp.gioiTinh = reader["gioitinh"].ToString();
                sp.soLuong = reader.GetInt16("soluong");
                sp.moTa = reader["mota"].ToString();
                sp.makm = reader.GetInt16("makm");
                reader.Close();
            }
            con.Close();
            return sp;
        }

        public static List<object> GetMakms()
        {
            con.Open();
            List<object> list = new List<object>();
            string sql = "select makm, phantramkm from khuyenmai";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var ob = new { makm = reader.GetInt16("makm"), phantram = reader.GetInt16("phantramkm") };
                    list.Add(ob);
                }
                reader.Close();
            }
            con.Close();
            return list;
        }
    }
}
