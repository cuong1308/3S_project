using _3S_project.Model;
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
                string sql = "SELECT TenUser, MatKhau, Quyen, MaGiangVien, Email, TrangThai FROM TaiKhoan where TenUser = @TenUser and MatKhau=@MatKhau and TrangThai = 1";
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
                        temp.TrangThai = reader.GetBoolean(5);

                        if(!reader.IsDBNull(3) )
                        {
                            dataGiangVien dataGiangVien = new dataGiangVien();
                            temp.GiangVien = dataGiangVien.getGiangVien(reader.GetInt32(3));
                        }

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

        public List<Model.TaiKhoan> getlstTaiKhoan(string user)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                string user_like = "%" + user + "%";
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT TenUser, MatKhau, Quyen, MaGiangVien, Email, TrangThai FROM TaiKhoan where TenUser like @TenUser ";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenUser", user_like);
                var reader = command.ExecuteReader();
                List<Model.TaiKhoan> lst = new List<Model.TaiKhoan>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Model.TaiKhoan temp = new Model.TaiKhoan();
                        temp.TenUser = reader.GetString(0);
                        temp.MatKhau = reader.GetString(1);
                        temp.Quyen = reader.GetInt32(2);
                        temp.Email = reader.GetString(4);
                        temp.TrangThai = reader.GetBoolean(5);

                        if (!reader.IsDBNull(3))
                        {
                            dataGiangVien dataGiangVien = new dataGiangVien();
                            temp.GiangVien = dataGiangVien.getGiangVien(reader.GetInt32(3));
                        }
                        else
                        {
                            temp.GiangVien = new GiangVien();
                        }
                        lst.Add(temp);

                    }
                    
                }
                else
                {
                    cnn.Close();
                    return null;

                }

                cnn.Close();
                return lst;

            }
        }

        public bool Them(string un,string maGiangVien ,int quyen , string pass, string email)
        {
            try
            {
                bool result = false;
                using (SqlConnection cnn = DbUtils.GetConnection())
                {
                    var command = new SqlCommand();
                    command.Connection = cnn;
                    string sql = "Insert into TaiKhoan(TenUser,MatKhau,Quyen,MaGiangVien, Email, TrangThai) Values (@TenUser,@MatKhau,@Quyen,@MaGiangVien, @Email, @TrangThai)";
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@TenUser", un);
                    command.Parameters.AddWithValue("@MatKhau", pass);
                    command.Parameters.AddWithValue("@Quyen", quyen);
                    command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@TrangThai", 1);
                    result = command.ExecuteNonQuery() > 0;
                    cnn.Close();
                }
                return result;

            }
            catch(Exception ex)
            {
                
            }
            return false;
        }

        public bool Sua(string un, string maGiangVien, int quyen, string pass, string email)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update TaiKhoan set MatKhau = @MatKhau ,Quyen = @Quyen ,MaGiangVien = @MaGiangVien, Email = @Email where TenUser = @TenUser";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenUser", un);
                command.Parameters.AddWithValue("@MatKhau", pass);
                command.Parameters.AddWithValue("@Quyen", quyen);
                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                command.Parameters.AddWithValue("@Email", email);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool KichHoat_VoHieuHoa(bool trangThai,string un)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update TaiKhoan set TrangThai = @TrangThai where TenUser = @TenUser";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenUser", un);
                command.Parameters.AddWithValue("@TrangThai", !trangThai);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }
        public int DoiMatKhau(string un, string passnew)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update TaiKhoan set MatKhau = @MatKhau where TenUser = @TenUser";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenUser", un);
                command.Parameters.AddWithValue("@MatKhau", passnew);
                var reader = command.ExecuteScalar();
                return 0;
            }
        }


    }
}
