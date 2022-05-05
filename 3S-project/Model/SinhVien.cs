using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Model
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime DateTime { get; set; }
        public string DiaChi { get; set; }
        public Lop Lop { get; set; }
    }
}
