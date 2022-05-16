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
                    temp.TenSinhVien = reader.GetString(1);
                    temp.GioiTinh = reader.GetBoolean(2);
                    temp.DateTime = reader.GetDateTime(3);
                    temp.DiaChi = reader.GetString(4);
                    dataLop dataLop = new dataLop();
                    temp.Lop = dataLop.getLop(reader.GetInt32(5));
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }


        public List<SinhVien> getlstSinhVien(string tenSinhVien)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {

                string tenSinhVien_like = "%" + tenSinhVien + "%";
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaSinhVien, TenSinhVien, GioiTinh, NgaySinh,DiaChi, MaLop FROM SinhVien where TrangThai = 1 and TenSinhVien like @TenSinhVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenSinhVien", tenSinhVien_like);
                var reader = command.ExecuteReader();

                List<SinhVien> lst = new List<SinhVien>();
                while (reader.Read())
                {
                    SinhVien temp = new SinhVien();
                    temp.MaSinhVien = reader.GetInt32(0);
                    temp.TenSinhVien = reader.GetString(1);
                    temp.GioiTinh = reader.GetBoolean(2);
                    temp.DateTime = reader.GetDateTime(3);
                    temp.DiaChi = reader.GetString(4);
                    dataLop dataLop = new dataLop();
                    temp.Lop = dataLop.getLop(reader.GetInt32(5));
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
                    temp.TenSinhVien = reader.GetString(1);
                    temp.GioiTinh = reader.GetBoolean(2);
                    temp.DateTime = reader.GetDateTime(3);
                    temp.DiaChi = reader.GetString(4);
                    dataLop dataLop = new dataLop();
                    temp.Lop = dataLop.getLop(reader.GetInt32(5));
                }
                cnn.Close();
                return temp;



            }
        }

        public bool Them(string tenSinhVien, bool gioiTinh, DateTime ngaySinh, string diaChi,int maLop)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Insert into SinhVien(TenSinhVien, GioiTinh, NgaySinh,DiaChi, TrangThai, MaLop) Values ( @TenSinhVien, @GioiTinh, @NgaySinh,@DiaChi, 1, @MaLop)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@MaLop", maLop);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Sua(int maSinhVien, string tenSinhVien, bool gioiTinh, DateTime ngaySinh, string diaChi, int maLop)
        {
            bool result = false;
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
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Xoa(int maSinhVien)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update SinhVien set TrangThai = 0 where MaSinhVien = @MaSinhVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }
    }
}
