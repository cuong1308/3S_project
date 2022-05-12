using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class dataSinhVien
    {
        public List<SinhVien> getlstSinhVien()
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaSinhVien, TenSinhVien, GioiTinh, NgaySinh,DiaChi, MaLop FROM SinhVien where TrangThai = 1";
                command.CommandText = sql;
                var reader = command.ExecuteReader();

                List<SinhVien> lst = new List<SinhVien>();
                while (reader.Read())
                {
                    SinhVien temp = new SinhVien();
                    temp.MaSinhVien = reader.GetInt32(0);
                    temp.TenSinhVen = reader.GetString(1);
                    temp.GioiTinh = reader.GetBoolean(2);
                    temp.DateTime = reader.GetDateTime(3);
                    temp.DiaChi = reader.GetString(4);
                    dataLop dataLop = new dataLop();
                    temp.Lop = dataLop.getLop(reader.GetInt32(6));
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public SinhVien getSinhVien(int maSinhVien)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaSinhVien, TenSinhVien, GioiTinh, NgaySinh,DiaChi, MaLop FROM SinhVien where TrangThai = 1 and MaSinhVien = @MaSinhVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                var reader = command.ExecuteReader();

                SinhVien temp = new SinhVien();
                if (reader.Read())
                {
                    temp.MaSinhVien = reader.GetInt32(0);
                    temp.TenSinhVen = reader.GetString(1);
                    temp.GioiTinh = reader.GetBoolean(2);
                    temp.DateTime = reader.GetDateTime(3);
                    temp.DiaChi = reader.GetString(4);
                    dataLop dataLop = new dataLop();
                    temp.Lop = dataLop.getLop(reader.GetInt32(6));
                }
                cnn.Close();
                return temp;



            }
        }

        public int Them(int maSinhVien, string tenSinhVien, bool gioiTinh, DateTime ngaySinh, string diaChi,int maLop)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Insert into SinhVien(MaSinhVien, TenSinhVien, GioiTinh, NgaySinh,DiaChi, TrangThai, MaLop) Values (@MaSinhVien, @TenSinhVien, @GioiTinh, @NgaySinh,@DiaChi, 1, @MaLop)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@MaLop", maLop);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Sua(int maSinhVien, string tenSinhVien, bool gioiTinh, DateTime ngaySinh, string diaChi, int maLop)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update SinhVien set TenSinhVien = @TenSinhVien, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, MaLop = @MaLop where MaSinhVien = @MaSinhVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@MaLop", maLop);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Xoa(int maSinhVien)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update SinhVien set TrangThai = 0 where MaSinhVien = @MaSinhVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }
    }
}
