using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Model
{
    public class Lop
    {
        public int MaLop { get; set; }
        public string TenLop { get; set;}
        public string KhoaHoc { get; set; }
        public Khoa Khoa { get; set; }
        public string TenKhoa { get { return Khoa.TenKhoa; } }
    }
}
