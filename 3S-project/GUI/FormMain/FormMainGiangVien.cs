using _3S_project.GUI.FormAdmin.TaiKhoan;
using _3S_project.GUI.FormGiangVien;
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
    public partial class FormMainGiangVien : Form
    {
        string tenTaiKhoan;
        string maGiangVien;
        public FormMainGiangVien(Model.TaiKhoan tk)
        {
            tenTaiKhoan = tk.TenUser;
            maGiangVien = tk.GiangVien.MaGiangVien.ToString();
            InitializeComponent();
            label2.Text = "Xin chào " + tk.TenUser;
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

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiem_GiangVien quanLyDiem_GiangVien = new QuanLyDiem_GiangVien(maGiangVien);
            quanLyDiem_GiangVien.ShowDialog();

        }
    }
}
