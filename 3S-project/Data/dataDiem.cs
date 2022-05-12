using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    internal class dataDiem
    {
        public List<Diem> getlstDiem()
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaSinhVien, MaLopHocPhan, DiemChuyenCan, DiemKiemTra1,DiemKiemTra2, DiemKiemTra3, DiemThi FROM Diem where TrangThai = 1";
                command.CommandText = sql;
                var reader = command.ExecuteReader();

                List<Diem> lst = new List<Diem>();
                while (reader.Read())
                {
                    Diem temp = new Diem();
                    dataSinhVien dataSinhVien = new dataSinhVien();
                    temp.SinhVien = dataSinhVien.getSinhVien(reader.GetInt32(0));
                    dataLopHocPhan dataLopHocPhan = new dataLopHocPhan();
                    temp.LopHocPhan = dataLopHocPhan.getLopHocPhan(reader.GetInt32(1));

                    temp.DiemChuyenCan = reader.GetFloat(2);
                    temp.DiemKiemTra1 = reader.GetFloat(3);
                    temp.DiemKiemTra2 = reader.GetFloat(4);
                    temp.DiemKiemTra3 = reader.GetFloat(5);
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public Diem getSinhVien(int maSinhVien, int maLopHocPhan)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "SELECT MaSinhVien, MaLopHocPhan, DiemChuyenCan, DiemKiemTra1,DiemKiemTra2, DiemKiemTra3, DiemThi FROM Diem where TrangThai = 1 and MaSinhVien = @MaSinhVien and MaLopHocPhan = @MaLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                var reader = command.ExecuteReader();

                Diem temp = new Diem();
                if (reader.Read())
                {
                    dataSinhVien dataSinhVien = new dataSinhVien();
                    temp.SinhVien = dataSinhVien.getSinhVien(reader.GetInt32(0));
                    dataLopHocPhan dataLopHocPhan = new dataLopHocPhan();
                    temp.LopHocPhan = dataLopHocPhan.getLopHocPhan(reader.GetInt32(1));

                    temp.DiemChuyenCan = reader.GetFloat(2);
                    temp.DiemKiemTra1 = reader.GetFloat(3);
                    temp.DiemKiemTra2 = reader.GetFloat(4);
                    temp.DiemKiemTra3 = reader.GetFloat(5);
                }
                cnn.Close();
                return temp;



            }
        }

        public int Them(int maSinhVien, int maLopHocPhan, float diemChuyenCan, float diemKiemTra1, float diemKiemTra2, float diemKiemTra3, float diemThi)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Insert into Diem(MaSinhVien, MaLopHocPhan, DiemChuyenCan, DiemKiemTra1,DiemKiemTra2, DiemKiemTra3, DiemThi, TrangThai) Values (MaSinhVien, MaLopHocPhan, DiemChuyenCan, DiemKiemTra1,DiemKiemTra2, DiemKiemTra3, DiemThi, 1)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                command.Parameters.AddWithValue("@DiemChuyenCan", diemChuyenCan);
                command.Parameters.AddWithValue("@DiemKiemTra1", diemKiemTra1);
                command.Parameters.AddWithValue("@DiemKiemTra2", diemKiemTra2);
                command.Parameters.AddWithValue("@DiemKiemTra3", diemKiemTra3);
                command.Parameters.AddWithValue("@DiemThi", diemThi);

                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Sua(int maSinhVien, int maLopHocPhan, float diemChuyenCan, float diemKiemTra1, float diemKiemTra2, float diemKiemTra3, float diemThi)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update Diem set DiemChuyenCan = @DiemChuyenCan, DiemKiemTra1 = @DiemKiemTra1, DiemKiemTra2 = @DiemKiemTra2, DiemKiemTra3 = @DiemKiemTra3, DiemThi = @DiemThi where MaSinhVien = @MaSinhVien and MaLopHocPhan = @MaLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                command.Parameters.AddWithValue("@DiemChuyenCan", diemChuyenCan);
                command.Parameters.AddWithValue("@DiemKiemTra1", diemKiemTra1);
                command.Parameters.AddWithValue("@DiemKiemTra2", diemKiemTra2);
                command.Parameters.AddWithValue("@DiemKiemTra3", diemKiemTra3);
                command.Parameters.AddWithValue("@DiemThi", diemThi);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }

        public int Xoa(int maSinhVien, int maLopHocPhan)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update Diem set TrangThai = 0 where MaSinhVien = @MaSinhVien and MaLopHocPhan = @MaLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                var reader = command.ExecuteScalar();

                return 0;
            }
        }
    }
}
