using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class dataLopHocPhan
    {
        public List<LopHocPhan> getlstLopHocPhan()
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaLopHocPhan, TenLopHocPhan,HocKi, NamHoc, MaMonHoc, MaGiangVien FROM LopHocPhan where TrangThai = 1";
                command.CommandText = sql;
                var reader = command.ExecuteReader();

                List<LopHocPhan> lst = new List<LopHocPhan>();
                while (reader.Read())
                {
                    LopHocPhan temp = new LopHocPhan();
                    temp.MaLopHocPhan = reader.GetInt32(0);
                    temp.TenLopHocPhan = reader.GetString(1);
                    temp.HocKi = reader.GetInt32(2);
                    temp.NamHoc = reader.GetString(3);
                    dataMonHoc dataMonHoc = new dataMonHoc();
                    dataGiangVien dataGiangVien = new dataGiangVien();
                    temp.MonHoc = dataMonHoc.getMonHoc(reader.GetInt32(4));
                    temp.GiangVien = dataGiangVien.getGiangVien(reader.GetInt32(5));
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }
        public List<LopHocPhan> getlstLopHocPhan(string tenLopHocPhan)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                string tenLopHocPhan_like = "%" + tenLopHocPhan + "%";
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaLopHocPhan, TenLopHocPhan,HocKi, NamHoc, MaMonHoc, MaGiangVien FROM LopHocPhan where TrangThai = 1 and TenLopHocPhan like @TenLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenLopHocPhan", tenLopHocPhan_like);
                var reader = command.ExecuteReader();

                List<LopHocPhan> lst = new List<LopHocPhan>();
                while (reader.Read())
                {
                    LopHocPhan temp = new LopHocPhan();
                    temp.MaLopHocPhan = reader.GetInt32(0);
                    temp.TenLopHocPhan = reader.GetString(1);
                    temp.HocKi = reader.GetInt32(2);
                    temp.NamHoc = reader.GetString(3);
                    dataMonHoc dataMonHoc = new dataMonHoc();
                    dataGiangVien dataGiangVien = new dataGiangVien();
                    temp.MonHoc = dataMonHoc.getMonHoc(reader.GetInt32(4));
                    temp.GiangVien = dataGiangVien.getGiangVien(reader.GetInt32(5));
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public LopHocPhan getLopHocPhan(int maLopHocPhan)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaLopHocPhan, TenLopHocPhan,HocKi, NamHoc, MaMonHoc, MaGiangVien FROM LopHocPhan where TrangThai = 1 and MaLopHocPhan = @MaLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                var reader = command.ExecuteReader();

                LopHocPhan temp = new LopHocPhan();
                if (reader.Read())
                {
                    temp.MaLopHocPhan = reader.GetInt32(0);
                    temp.TenLopHocPhan = reader.GetString(1);
                    temp.HocKi = reader.GetInt32(2);
                    temp.NamHoc = reader.GetString(3);
                    dataMonHoc dataMonHoc = new dataMonHoc();
                    dataGiangVien dataGiangVien = new dataGiangVien();
                    temp.MonHoc = dataMonHoc.getMonHoc(reader.GetInt32(4));
                    temp.GiangVien = dataGiangVien.getGiangVien(reader.GetInt32(5));
                }
                cnn.Close();
                return temp;



            }
        }

        public bool Them( string tenLopHocPhan, int hocKi, string namHoc, int maMonHoc, int maGiangVien)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Insert into LopHocPhan( TenLopHocPhan, HocKi, NamHoc, TrangThai, MaMonHoc, MaGiangVien) Values (@TenLopHocPhan,@HocKi,@NamHoc,1,@MaMonHoc, @MaGiangVien)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenLopHocPhan", tenLopHocPhan);
                command.Parameters.AddWithValue("@HocKi", hocKi);
                command.Parameters.AddWithValue("@NamHoc", namHoc);
                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);

                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Sua(int maLopHocPhan, string tenLopHocPhan, int hocKi, string namHoc, int maMonHoc, int maGiangVien)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update LopHocPhan set TenLopHocPhan = @TenLopHocPhan, HocKi = @HocKi, NamHoc = @NamHoc, MaMonHoc= @MaMonHoc, MaGiangVien = @MaGiangVien where MaLopHocPhan = @MaLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                command.Parameters.AddWithValue("@TenLopHocPhan", tenLopHocPhan);
                command.Parameters.AddWithValue("@HocKi", hocKi);
                command.Parameters.AddWithValue("@NamHoc", namHoc);
                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Xoa(int maLopHocPhan)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update LopHocPhan set TrangThai = 0 where MaLopHocPhan = @MaLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }
    }
}
