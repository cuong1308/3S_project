using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Model
{
    public class LopHocPhan
    {
        public string MaLopHocPhan { get; set; }
        public string TenLopHocPhan { get; set; }
        public int HocKi { get; set; }
        public string NamHoc { get; set; }
        public MonHoc MonHoc { get; set; }
        public GiangVien GiangVien { get; set; }
    }
}
