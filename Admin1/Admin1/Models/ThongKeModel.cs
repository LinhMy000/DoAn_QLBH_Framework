using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin1.Models
{
    public class ThongKeModel
    {
        private static MySqlConnection con = Connection.GetConnection();

        public static List<object> DoanhThu()
        {
            con.Open();
            List<object> list = new List<object>();
            string sql = "SELECT month(nghd) as thang, SUM(trigia) as doanhthu FROM hoadon GROUP BY thang;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var ob = new { thang = reader.GetInt16(0), doanhthu = reader.GetDouble(1) };
                    list.Add(ob);
                }
                reader.Close();
            }
            con.Close();
            return list;
        }

        public static List<object> TopSanPham()
        {
            con.Open();
            List<object> list = new List<object>();
            string sql = "SELECT cthd.masp, tensp, SUM(cthd.sl) as soluong FROM sanpham, cthd WHERE sanpham.masp = cthd.masp GROUP BY cthd.masp, tensp ORDER BY soluong DESC LIMIT 10;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var ob = new { sp = reader.GetString(1).ToString(), sl = reader.GetInt16(2) };
                    list.Add(ob);
                }
                reader.Close();
            }
            con.Close();
            return list;
        }

        public static List<object> TopKhachHang()
        {
            con.Open();
            List<object> list = new List<object>();
            string sql = "SELECT hoten, doanhso FROM khachhang ORDER BY doanhso DESC LIMIT 3;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var ob = new { ten = reader.GetString(0).ToString(), sl = reader.GetDouble(1) };
                    list.Add(ob);
                }
                reader.Close();
            }
            con.Close();
            return list;
        }
    }
}
