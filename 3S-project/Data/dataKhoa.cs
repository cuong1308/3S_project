using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class dataKhoa
    {
        public List<Khoa> getlstKhoa()
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaKhoa, TenKhoa FROM Khoa where TrangThai = 1";
                command.CommandText = sql;
                var reader = command.ExecuteReader();

                List<Khoa> lst = new List<Khoa>();
                while (reader.Read())
                {
                    Khoa temp = new Khoa();
                    temp.MaKhoa = reader.GetInt32(0);   
                    temp.TenKhoa = reader.GetString(1);
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }
        public List<Khoa> getlstKhoa(string tenKhoa)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                string tenKhoa_like = "%" + tenKhoa + "%";
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaKhoa, TenKhoa FROM Khoa where TrangThai = 1 and TenKhoa like @TenKhoa";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenKhoa", tenKhoa_like);
                var reader = command.ExecuteReader();

                List<Khoa> lst = new List<Khoa>();
                while (reader.Read())
                {
                    Khoa temp = new Khoa();
                    temp.MaKhoa = reader.GetInt32(0);
                    temp.TenKhoa = reader.GetString(1);
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public Khoa getKhoa(int maKhoa)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaKhoa, TenKhoa FROM Khoa where MaKhoa = @MaKhoa and TrangThai = 1";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                var reader = command.ExecuteReader();

                Khoa temp = new Khoa();
                if (reader.Read())
                {
                    temp.MaKhoa = reader.GetInt32(0);
                    temp.TenKhoa = reader.GetString(1);
                }
                cnn.Close();
                return temp;



            }
        }

        public bool Them(string tenKhoa)
        {
            bool result = false;
            bool check = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "select* from Khoa where TenKhoa = @TenKhoa and TrangThai = 1";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenKhoa", tenKhoa);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    check = true;
                }

                cnn.Close();
            }
            if (check is false)
            {
                using (SqlConnection cnn = DbUtils.GetConnection())
                {
                    var command = new SqlCommand();
                    command.Connection = cnn;
                    string sql = "Insert into Khoa(TenKhoa,TrangThai) Values (@TenKhoa,1)";
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@TenKhoa", tenKhoa);
                    result = command.ExecuteNonQuery() > 0;
                    cnn.Close();
                }
            }
            return result;
        }

        public bool Sua(int maKhoa, string tenKhoa)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update Khoa set TenKhoa = @TenKhoa where MaKhoa = @MaKhoa";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                command.Parameters.AddWithValue("@TenKhoa", tenKhoa);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Xoa(int maKhoa)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update Khoa set TrangThai = 0 where MaKhoa = @MaKhoa";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }
    }
}
