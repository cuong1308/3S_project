using _3S_project.GUI.FormAdmin.FormDiem;
using _3S_project.GUI.FormAdmin.FormMonHoc;
using _3S_project.GUI.FormAdmin.FormQuanLyKhoa;
using _3S_project.GUI.FormAdmin.FormQuanLyTaiKhoan;
using _3S_project.GUI.FormAdmin.FormSinhVien;
using _3S_project.GUI.FormAdmin.FormThongKe;
using _3S_project.GUI.FormAdmin.QuanLyGiangVien;
using _3S_project.GUI.FormAdmin.TaiKhoan;
using _3S_project.GUI.FormQuanLyLop;
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

namespace _3S_project.GUI.FormMain
{
    public partial class FormMainAdmin : Form
    {
        string tenTaiKhoan;
        public FormMainAdmin(TaiKhoan tk)
        {

            tenTaiKhoan = tk.TenUser;
            InitializeComponent();
            label2.Text = "Xin chào "+ tk.TenUser;
        }

        private void quảnLýTaiffKhoảnUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan taiKhoan = new QuanLyTaiKhoan();
            taiKhoan.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoiMatKhau = new FormDoiMatKhau(tenTaiKhoan);
            formDoiMatKhau.temp = labTenTk.Text;
            formDoiMatKhau.ShowDialog();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quanlylop quanlylop = new Quanlylop();
            quanlylop.ShowDialog();
        }

        private void quảnLýLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLopHocPhan quanLyLopHocPhan = new QuanLyLopHocPhan();
            quanLyLopHocPhan.ShowDialog();

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiem quanLyDiem = new QuanLyDiem();
            quanLyDiem.ShowDialog();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMonHoc frmMH = new frmQuanLyMonHoc();
            frmMH.ShowDialog();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGV formGV = new FormGV();
            formGV.ShowDialog();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien frmQLSV = new frmQuanLySinhVien();
            frmQLSV.ShowDialog();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKhoa formQuanLyKhoa = new FormQuanLyKhoa();
            formQuanLyKhoa.ShowDialog();
        }

        private void theoTrungBìnhMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeTrungBinhMon thongKeTrungBinhMon = new ThongKeTrungBinhMon();
            thongKeTrungBinhMon.ShowDialog();
        }

        private void theoMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeMonHoc thongKeMonHoc = new ThongKeMonHoc();
            thongKeMonHoc.ShowDialog();
        }

        private void theoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeLop thongKeLop = new ThongKeLop();
            thongKeLop.ShowDialog();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
