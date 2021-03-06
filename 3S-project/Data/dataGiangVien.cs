using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class dataGiangVien
    {
        public List<GiangVien> getlstGiangVien()
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaGiangVien, TenGiangVien FROM GiangVien where TrangThai = 1";
                command.CommandText = sql;
                var reader = command.ExecuteReader();

                List<GiangVien> lst = new List<GiangVien>();
                while (reader.Read())
                {
                    GiangVien temp = new GiangVien();
                    temp.MaGiangVien = reader.GetInt32(0);
                    temp.TenGiangVien = reader.GetString(1);
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public List<GiangVien> getlstGiangVien(string tenGiangVien)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                string tenGiangVien_like = "%" + tenGiangVien + "%";
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaGiangVien, TenGiangVien FROM GiangVien where TrangThai = 1 and TenGiangVien like @TenGiangVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenGiangVien", tenGiangVien_like);
                var reader = command.ExecuteReader();

                List<GiangVien> lst = new List<GiangVien>();
                while (reader.Read())
                {
                    GiangVien temp = new GiangVien();
                    temp.MaGiangVien = reader.GetInt32(0);
                    temp.TenGiangVien = reader.GetString(1);
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public GiangVien getGiangVien(int maGiangVien)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaGiangVien, TenGiangVien FROM GiangVien where MaGiangVien = @MaGiangVien and TrangThai = 1";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                var reader = command.ExecuteReader();

                GiangVien temp = new GiangVien();
                if (reader.Read())
                {
                    temp.MaGiangVien = reader.GetInt32(0);
                    temp.TenGiangVien = reader.GetString(1);
                }
                cnn.Close();
                return temp;



            }
        }

        public bool Them(string tenGiangVien)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Insert into GiangVien(TenGiangVien,TrangThai) Values (@TenGiangVien,1)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenGiangVien", tenGiangVien);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Sua(int maGiangVien, string tenGiangVien)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update GiangVien set TenGiangVien = @TenGiangVien where MaGiangVien = @MaGiangVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                command.Parameters.AddWithValue("@TenGiangVien", tenGiangVien);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Xoa(int maGiangVien)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update GiangVien set TrangThai = 0 where MaGiangVien = @MaGiangVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

    }
}
