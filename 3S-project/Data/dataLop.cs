using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class dataLop
    {
        public List<Lop> getlstLop()
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaLop, TenLop FROM Lop where TrangThai = 1";
                command.CommandText = sql;
                var reader = command.ExecuteReader();

                List<Lop> lst = new List<Lop>();
                while (reader.Read())
                {
                    Lop temp = new Lop();
                    temp.MaLop = reader.GetInt32(0);
                    temp.TenLop = reader.GetString(1);
                    temp.KhoaHoc = reader.GetString(2);
                    dataKhoa dataKhoa = new dataKhoa();
                    temp.Khoa = dataKhoa.getKhoa(reader.GetInt32(3));
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public Lop getLop(int maLop)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaLop, TenLop, KhoaHoc, MaKhoa FROM Lop where MaLop = @MaLop and TrangThai = 1";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaLop", maLop);
                var reader = command.ExecuteReader();

                Lop temp = new Lop();
                if (reader.Read())
                {
                    temp.MaLop = reader.GetInt32(0);
                    temp.TenLop = reader.GetString(1);
                    temp.KhoaHoc = reader.GetString(2);
                    dataKhoa dataKhoa = new dataKhoa();
                    temp.Khoa = dataKhoa.getKhoa(reader.GetInt32(3));
                }
                cnn.Close();
                return temp;



            }
        }

        public int Them(int maLop, string tenLop, string khoaHoc, int maKhoa)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Insert into Lop(MaLop, TenLop, KhoaHoc, MaKhoa,TrangThai) Values (@MaLop, @TenLop, @KhoaHoc, @MaKhoa,1)";
                command.CommandText = sql;

                command.Parameters.AddWithValue("@MaLop", maLop);
                command.Parameters.AddWithValue("@TenLop", tenLop);
                command.Parameters.AddWithValue("@KhoaHoc", khoaHoc);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Sua(int maLop, string tenLop, string khoaHoc, int maKhoa)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update Lop set TenLop = @TenKhoa, KhoaHoc = @KhoaHoc, MaKhoa = @MaKhoa where MaLop = @MaLop";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaLop", maLop);
                command.Parameters.AddWithValue("@TenLop", maLop);
                command.Parameters.AddWithValue("@KhoaHoc", maLop);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Xoa(int maLop)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update Lop set TrangThai = 0 where MaLop = @MaLop";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaLop", maLop);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }
    }
}
