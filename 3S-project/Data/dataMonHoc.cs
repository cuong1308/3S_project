
using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class dataMonHoc
    {
        public List<MonHoc> getlstMonHoc()
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaMonHoc, TenMonHoc,DonViPhuTrach, TinChi FROM MonHoc where TrangThai = 1";
                command.CommandText = sql;
                var reader = command.ExecuteReader();

                List<MonHoc> lst = new List<MonHoc>();
                while (reader.Read())
                {
                    MonHoc temp = new MonHoc();
                    temp.MaMonHoc = reader.GetInt32(0);
                    temp.TenMonHoc = reader.GetString(1);
                    temp.DonViPhuTrach = reader.GetString(2);
                    temp.TinChi = reader.GetInt32(3);
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public MonHoc getMonHoc(int maMonHoc)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaMonHoc, TenMonHoc,DonViPhuTrach, TinChi FROM MonHoc where TrangThai = 1 and MaMonHoc = @MaMonHoc";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                var reader = command.ExecuteReader();

                MonHoc temp = new MonHoc();
                if (reader.Read())
                {
                    temp.MaMonHoc = reader.GetInt32(0);
                    temp.TenMonHoc = reader.GetString(1);
                    temp.DonViPhuTrach = reader.GetString(2);
                    temp.TinChi = reader.GetInt32(3);
                }
                cnn.Close();
                return temp;



            }
        }

        public int Them( string tenMonHoc,string donViPhuTrach, int tinChi)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Insert into MonHoc( TenMonHoc, DonViPhuTrach, TinChi, TrangThai) Values (@TenMonHoc,@DonViPhuTrach,@TinChi,1)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@TenMonHoc", tenMonHoc);
                command.Parameters.AddWithValue("@DonViPhuTrach", donViPhuTrach);
                command.Parameters.AddWithValue("@TinChi", tinChi);

                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Sua(int maMonHoc, string tenMonHoc, string donViPhuTrach, int tinChi)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update GiangVien set TenMonHoc = @TenMonHoc, DonViPhuTrach = @DonViPhuTrach, TinChi = @TinChi where MaMonHoc = @MaMonHoc";
                command.CommandText = sql;
                
                command.Parameters.AddWithValue("@TenMonHoc", tenMonHoc);
                command.Parameters.AddWithValue("@DonViPhuTrach", donViPhuTrach);
                command.Parameters.AddWithValue("@TinChi", tinChi);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Xoa(int maMonHoc)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update MonHoc set TrangThai = 0 where MaMonHoc = @MaMonHoc";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc); 
                var reader = command.ExecuteScalar();

                return 0;
            }
        }
    }
}
