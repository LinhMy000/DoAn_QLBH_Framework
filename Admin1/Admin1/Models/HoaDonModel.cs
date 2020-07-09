using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Admin1.Models
{
    public class HoaDon
    {
        public int? sohd { set; get; }
        public DateTime ngahd { set; get; }
        public string makh { set; get; }
        public double trigia { set; get; }
        public string tinhtrang { set; get; }
        public string ghichu { set; get; }
        public int thanhtoan { set; get; }
    }

    public class HoaDonContext
    {
        private static MySqlConnection con = Connection.GetConnection();

        public static List<HoaDon> GetHoaDons()
        {
            con.Open();
            List<HoaDon> list = new List<HoaDon>();
            HoaDon kh;
            string sql = "select * from hoadon";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    kh = new HoaDon();
                    kh.sohd = reader.GetInt16(0);
                    kh.makh = reader[2].ToString();
                    kh.ngahd = reader.GetDateTime(1);
                    kh.trigia = reader.GetDouble(3);
                    kh.tinhtrang = reader[4].ToString();
                    kh.ghichu = reader[6].ToString();
                    kh.thanhtoan = reader.GetInt16(5);
                    list.Add(kh);
                }
                reader.Close();
            }
            con.Close();
            return list;
        }

        public static int UpdateHoaDon(HoaDon kh)
        {
            con.Open();
            string sql = "update hoadon set trigia=@tg, tinhtrang=@tt, thanhtoan=@tht, ghichu=@gc where sohd=@sohd";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("tg", kh.trigia);
            cmd.Parameters.AddWithValue("tt", kh.tinhtrang);
            cmd.Parameters.AddWithValue("tht", kh.thanhtoan);
            cmd.Parameters.AddWithValue("gc", kh.ghichu);
            cmd.Parameters.AddWithValue("sohd", kh.sohd);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static int DeleteHoaDon(int id)
        {
            con.Open();
            string sql = "delete from HoaDon where sohd=@sohd";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sohd", id);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }

        public static HoaDon FindHoaDon(int id)
        {
            con.Open();
            HoaDon kh = new HoaDon();
            string sql = "select * from HoaDon where sohd=@sohd";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sohd", id);
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                kh.sohd = reader.GetInt16(0);
                kh.makh = reader[2].ToString();
                kh.ngahd = reader.GetDateTime(1);
                kh.trigia = reader.GetDouble(3);
                kh.tinhtrang = reader[4].ToString();
                kh.ghichu = reader[6].ToString();
                kh.thanhtoan = reader.GetInt16(5);
                reader.Close();
            }
            con.Close();
            return kh;
        }
    }
}
