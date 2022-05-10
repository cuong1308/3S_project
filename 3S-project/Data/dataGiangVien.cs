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
                string sql = "SELECT MaGiangVien, TenGiangVien FROM GiangVien";
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
    }
}
