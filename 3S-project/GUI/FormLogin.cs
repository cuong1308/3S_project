using _3S_project.Data;
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
                Form1 form1 = new Form1(tk);
                form1.ShowDialog();
            }
            else if (tk.Quyen == 2)
            {
                FormMainQuanLy form2 = new FormMainQuanLy(tk);
                form2.ShowDialog();
            }
            else if (tk.Quyen == 3)
            {
                FormMainGiangVien form3 = new FormMainGiangVien(tk);
                form3.ShowDialog();
            }
            else
                MessageBox.Show("Nhập sai vui lòng thử lại");


        }
    }
}
