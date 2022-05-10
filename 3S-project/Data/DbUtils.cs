using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Data
{
    public static class DbUtils
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                var connectionString = "Server=localhost;Database=QuanLyDiemSinhVien;User Id=sa;Password=123;";
                var cnn = new SqlConnection(connectionString);

                cnn.Open();
                
                

                return cnn;
            }
            catch (Exception exc)
            {
                throw new Exception("Không kết nối đến cơ sở dữ liệu được", exc);
            }
        }
    }
}
