using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class TaiKhoan
    {
        public Model.TaiKhoan kiemTraDangNhap(string user,string pass)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT TenUser, MatKhau, Quyen, MaGiangVien, Email FROM TaiKhoan where TenUser = @TenUser and MatKhau=@MatKhau";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenUser",user);
                command.Parameters.AddWithValue("@MatKhau", pass);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Model.TaiKhoan temp = new Model.TaiKhoan();
                    if (reader.Read())
                    {
                        temp.TenUser = reader.GetString(0);
                        temp.MatKhau = reader.GetString(1);
                        temp.Quyen = reader.GetInt32(2);
                        temp.Email = reader.GetString(4);

                    }
                    cnn.Close();
                    return temp;
                }
                else
                {
                    cnn.Close();
                    return null;

                }

                
            }
        }
    }
}
