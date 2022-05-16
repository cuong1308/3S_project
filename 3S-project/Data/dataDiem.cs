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
        public List<Diem> getlstDiem(string tenSinhVien,string tenLopHocPhan,string tenMonHoc,string maSinhVien)
        {
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                string tenSinhVien_like = "%" + tenSinhVien + "%";
                string tenLopHocPhan_like = "%" + tenLopHocPhan + "%";
                string tenLop_like = "%" + tenMonHoc + "%";
                string maSinhVien_like = "%" + maSinhVien + "%";

                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = @"SELECT d.MaSinhVien, d.MaLopHocPhan, d.DiemChuyenCan, d.DiemKiemTra1,d.DiemKiemTra2, d.DiemKiemTra3, d.DiemThi 
                                FROM Diem as d
                                    join SinhVien as sv on d.MaSinhVien = sv.MaSinhVien
                                    join LopHocPhan as lhp on d.MaLopHocPhan = lhp.MaLopHocPhan
                                    join MonHoc as mh on mh.MaMonHoc = lhp.MaMonHoc
                                where d.TrangThai = 1 and TenLopHocPhan like @TenLopHocPhan and TenSinhVien like @TenSinhVien and mh.TenMonHoc like @TenLop and sv.MaSinhVien like @MaSinhVien";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien_like);
                command.Parameters.AddWithValue("@TenLopHocPhan", tenLopHocPhan_like);
                command.Parameters.AddWithValue("@TenLop", tenLop_like);
                command.Parameters.AddWithValue("@TenSinhVien", tenSinhVien_like);

                var reader = command.ExecuteReader();

                List<Diem> lst = new List<Diem>();
                while (reader.Read())
                {
                    Diem temp = new Diem();
                    dataSinhVien dataSinhVien = new dataSinhVien();
                    temp.SinhVien = dataSinhVien.getSinhVien(reader.GetInt32(0));
                    dataLopHocPhan dataLopHocPhan = new dataLopHocPhan();
                    temp.LopHocPhan = dataLopHocPhan.getLopHocPhan(reader.GetInt32(1));

                    temp.DiemChuyenCan = (float)reader.GetDouble(2);
                    temp.DiemKiemTra1 = (float)reader.GetDouble(3);
                    temp.DiemKiemTra2 = (float)reader.GetDouble(4);
                    temp.DiemKiemTra3 = (float)reader.GetDouble(5);
                    temp.DiemThi = (float)reader.GetDouble(6);
                    lst.Add(temp);
                }
                cnn.Close();
                return lst;



            }
        }

        public Diem getDiem(int maSinhVien, int maLopHocPhan)
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

        public bool Them(int maSinhVien, int maLopHocPhan, float diemChuyenCan, float diemKiemTra1, float diemKiemTra2, float diemKiemTra3, float diemThi)
        {
            bool result = false;
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

                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Sua(int maSinhVien, int maLopHocPhan, float diemChuyenCan, float diemKiemTra1, float diemKiemTra2, float diemKiemTra3, float diemThi)
        {
            bool result = false;
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

                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }

        public bool Xoa(int maSinhVien, int maLopHocPhan)
        {
            bool result = false;
            using (SqlConnection cnn = DbUtils.GetConnection())
            {
                var command = new SqlCommand();
                command.Connection = cnn;
                string sql = "Update Diem set TrangThai = 0 where MaSinhVien = @MaSinhVien and MaLopHocPhan = @MaLopHocPhan";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                command.Parameters.AddWithValue("@MaLopHocPhan", maLopHocPhan);
                result = command.ExecuteNonQuery() > 0;
                cnn.Close();
            }
            return result;
        }
    }
}
