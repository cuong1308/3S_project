using _3S_project.Data;
using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI.FormAdmin.FormDiem
{
    public partial class NhapDiem : Form
    {
        Diem diem1 = new Diem();
        public NhapDiem(Model.Diem diem)
        {

            InitializeComponent();
            diem1 = diem;
            lMaSinhVien.Text = lMaSinhVien.Text + ": " + diem.MaSinhVien;
            lMaLopHocPhan.Text = lMaLopHocPhan.Text + ": " + diem.LopHocPhan.MaLopHocPhan;
            LTenSinhVien.Text = LTenSinhVien.Text + ": " + diem.TenSinhVien;
            lTenLopHocPhan.Text = lTenLopHocPhan.Text + ": " + diem.TenLopHocPhan;
            numDiemChuyenCan.Value = (decimal)diem.DiemChuyenCan;
            numDiemKiemTra1.Value = (decimal)diem.DiemKiemTra1;
            numDiemKiemTra2.Value = (decimal)diem.DiemKiemTra2;
            numDiemKiemTra3.Value = (decimal)diem.DiemKiemTra3;
            numDiemThi.Value = (decimal)diem.DiemThi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI

            float diemChuyenCan = (float)numDiemChuyenCan.Value;
            float diemKiemTra1 = (float)numDiemKiemTra1.Value;
            float diemKiemTra2 = (float)numDiemKiemTra2.Value;
            float diemKiemTra3 = (float)numDiemKiemTra3.Value;
            float diemThi = (float)numDiemThi.Value;
            //int maKhoa = selectedNXB.MaKhoa;

            //Kiểm tra tính hợp lệ của dữ liệu


            // 3. Thực hiện lưu lên csdl
            dataDiem dtDiem = new dataDiem();
            if (dtDiem.Sua(diem1.MaSinhVien,diem1.LopHocPhan.MaLopHocPhan,diemChuyenCan,diemKiemTra1,diemKiemTra2,diemKiemTra3,diemThi))
            {
                MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
