using _3S_project.GUI.FormAdmin.FormMonHoc;
using _3S_project.GUI.FormAdmin.FormQuanLyKhoa;
using _3S_project.GUI.FormAdmin.FormSinhVien;
using _3S_project.GUI.FormAdmin.FormThongKe;
using _3S_project.GUI.FormAdmin.QuanLyGiangVien;
using _3S_project.GUI.FormAdmin.TaiKhoan;
using _3S_project.GUI.FormQuanLyLop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI.FormMain
{
    public partial class FormMainQuanLy : Form
    {
        string tentk;
        public FormMainQuanLy(Model.TaiKhoan tk)
        {
            InitializeComponent();
            tentk = tk.TenUser;
            label2.Text = "Xin chào " + tk.TenUser;
        }

        private void quảnLýLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quanlylop frmQLLop = new Quanlylop();
            frmQLLop.ShowDialog();

        }

        private void quảnLýLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLopHocPhan frmQLLHP = new QuanLyLopHocPhan();
            frmQLLHP.ShowDialog();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMonHoc frmQLMH = new frmQuanLyMonHoc();
            frmQLMH.ShowDialog();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGV frmGV = new FormGV();
            frmGV.ShowDialog(); 
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien frmQLSV = new frmQuanLySinhVien();
            frmQLSV.ShowDialog();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKhoa frmQLKhoa = new FormQuanLyKhoa();      
            frmQLKhoa.ShowDialog();
        }

        private void theoTrungBìnhMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeTrungBinhMon frmTKMonHoc = new ThongKeTrungBinhMon();
            frmTKMonHoc.ShowDialog();
        }

        private void theoMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeMonHoc frmTKMH = new ThongKeMonHoc();
            frmTKMH.ShowDialog();
        }

        private void theoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeLop frmTKLop = new ThongKeLop();
            frmTKLop.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frmDMK = new FormDoiMatKhau(tentk);
            frmDMK.temp = TenTKK.Text;
            frmDMK.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
