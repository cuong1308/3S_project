using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_project.Model
{
    public class Diem
    {
        public SinhVien SinhVien { get; set; }
        public LopHocPhan LopHocPhan { get; set; }
        public float DiemChuyenCan { get; set; }
        public float DiemKiemTra1 { get; set; }
        public float DiemKiemTra2 { get; set; }
        public float DiemKiemTra3 { get; set; }
        public float DiemThi { get; set; }
        public int MaSinhVien { get { return SinhVien.MaSinhVien; } }
        public string TenSinhVien { get { return SinhVien.TenSinhVien; } }
        public string TenLop { get {return SinhVien.Lop.TenLop; } }
        public string TenLopHocPhan { get { return LopHocPhan.TenLopHocPhan; } }
    }
}
