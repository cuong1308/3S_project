using _3S_project.Data;
using _3S_project.GUI.FormMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text;
            var matKhau = txtMatKhau.Text;
            var dataTaiKhoan = new TaiKhoan();
            Model.TaiKhoan tk = dataTaiKhoan.kiemTraDangNhap(tenDangNhap, matKhau);
            if(tk == null)
                MessageBox.Show("Nhập sai vui lòng thử lại");
            else if (tk.Quyen==1)
            {
                FormMainAdmin form1 = new FormMainAdmin(tk);
                form1.ShowDialog();
            }
            else if (tk.Quyen == 2)
            {
                FormMain.FormMainQuanLy form2 = new FormMain.FormMainQuanLy(tk);
                form2.ShowDialog();
            }
            else if (tk.Quyen == 3)
            {
                FormMain.FormMainGiangVien form3 = new FormMain.FormMainGiangVien(tk);
                form3.ShowDialog();
            }
            else
                MessageBox.Show("Nhập sai vui lòng thử lại");


        }
    }
}
