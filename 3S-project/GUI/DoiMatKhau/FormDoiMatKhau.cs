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
namespace _3S_project.GUI.FormAdmin.TaiKhoan
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
            
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string ttk = txtTenTaiKhoan.Text;
            string mkc = txtMatKhauCu.Text;
            string mkm = txtMatKhauMoi.Text;
            string nlmk = txtNhapLaiMatKhau.Text;
            if (string.IsNullOrWhiteSpace(ttk))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(mkc))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(mkm))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            if (string.IsNullOrWhiteSpace(nlmk))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.Compare(mkc, mkm) == 0)
            {
                MessageBox.Show("Mật khẩu cũ và mật khẩu mới trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(string.Compare(mkm, nlmk) != 0 )
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            var dataTK = new Data.TaiKhoan();
            Model.TaiKhoan tk = dataTK.kiemTraDangNhap(ttk, mkc);            
            if(tk == null)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var dtTK = new Data.TaiKhoan();
                dtTK.DoiMatKhau(txtTenTaiKhoan.Text, txtMatKhauMoi.Text);
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
        }
      

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        public string temp;
        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = temp;
            txtTenTaiKhoan.Visible = false;
            
        }
    }
}
