using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Admin1.Models
{
    public class KhachHang
    {
        public int? makh { set; get; }
        public string hoten { set; get; }
        public string dchi { set; get; }
        public string sodt { set; get; }
        public DateTime? ngsinh { set; get; }
        public DateTime? ngdk { set; get; }
        public double doanhso { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public int loaitk { set; get; }
        /*
        public KhachHang()
        {
            makh = null;
            hoten = null;
            dchi = null;
            sodt = null;
            ngsinh = null;
            ngdk = null;
            doanhso = 0;
            username = null;
            password = null;
            loaitk = 0;
        }
        */
    }

    public class KhachHangContext
    {
        private static MySqlConnection con = Connection.GetConnection();

        public static List<KhachHang> GetKhachHangs()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            List<KhachHang> list = new List<KhachHang>();
            KhachHang kh;
            string sql = "select * from khachhang k, taikhoan t where k.makh=t.makh";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    kh = new KhachHang();
                    kh.makh = reader.GetInt16(0);
                    kh.hoten = reader[1].ToString();
                    kh.dchi = reader[2].ToString();
                    kh.sodt = reader[3].ToString();
                    kh.ngsinh = reader.GetDateTime(4);
                    kh.ngdk = reader.GetDateTime(5);
                    kh.doanhso = reader.GetDouble(6);
                    kh.username = reader[8].ToString();
                    kh.password = reader[9].ToString();
                    kh.loaitk = reader.GetInt16(10);
                    list.Add(kh);
                }
                reader.Close();
            }
            con.Close();
            return list;
        }

        public static int InsertKhachHang(KhachHang kh)
        {
            con.Open();
            string sql = "insert into khachhang values(null, @hoten, @dchi, @sodt, @ngsinh, @ngdk, 0, null)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("hoten", kh.hoten);
            cmd.Parameters.AddWithValue("dchi", kh.dchi);
            cmd.Parameters.AddWithValue("sodt", kh.sodt);
            cmd.Parameters.AddWithValue("ngsinh", kh.ngsinh);
            cmd.Parameters.AddWithValue("ngdk", kh.ngdk);
            //cmd.Parameters.AddWithValue("doanhso", kh.doanhso);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static int FindLastId()
        {
            con.Open();
            int id = 0;
            string sql = "select max(makh) as id from khachhang";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                id = reader.GetInt16(0);
                reader.Close();
            }
            con.Close();
            return id;
        }

        public static int InsertTaiKhoan(KhachHang kh)
        {
            InsertKhachHang(kh);
            int id = FindLastId();
            con.Open();
            string sql = "insert into taikhoan values(@username, @password, @loaitk, @makh)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("username", kh.username);
            cmd.Parameters.AddWithValue("password", kh.password);
            cmd.Parameters.AddWithValue("loaitk", kh.loaitk);
            cmd.Parameters.AddWithValue("makh", id);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static int UpdateKhachHang(KhachHang kh)
        {
            con.Open();
            string sql = "update khachhang set hoten=@hoten, dchi=@dchi, sodt=@sodt, ngsinh=@ngsinh, ngdk=@ngdk, doanhso=@doanhso where makh=@makh; update taikhoan set username=@username, password=@password, loaitk=@loaitk where makh=@makh;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("hoten", kh.hoten);
            cmd.Parameters.AddWithValue("dchi", kh.dchi);
            cmd.Parameters.AddWithValue("sodt", kh.sodt);
            cmd.Parameters.AddWithValue("ngsinh", kh.ngsinh);
            cmd.Parameters.AddWithValue("ngdk", kh.ngdk);
            cmd.Parameters.AddWithValue("doanhso", kh.doanhso);
            cmd.Parameters.AddWithValue("username", kh.username);
            cmd.Parameters.AddWithValue("password", kh.password);
            cmd.Parameters.AddWithValue("loaitk", kh.loaitk);
            cmd.Parameters.AddWithValue("makh", kh.makh);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static int DeleteKhachHang(int id)
        {
            con.Open();
            string sql = "delete from taikhoan where makh=@makh; delete from khachhang where makh=@makh;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("makh", id);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static KhachHang FindKhachHang(int id)
        {
            con.Open();
            KhachHang kh = new KhachHang();
            string sql = "select * from khachhang k, taikhoan t where k.makh=t.makh and k.makh=@makh";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("makh", id);
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                kh.makh = reader.GetInt16(0);
                kh.hoten = reader.GetString(1);
                kh.dchi = reader.GetString(2);
                kh.sodt = reader.GetString(3);
                kh.ngsinh = reader.GetDateTime(4);
                kh.ngdk = reader.GetDateTime(5);
                kh.doanhso = reader.GetDouble(6);
                kh.username = reader.GetString(8);
                kh.password = reader.GetString(9);
                kh.loaitk = reader.GetInt16(10);
                reader.Close();
            }
            con.Close();
            return kh;
        }
    }
}
