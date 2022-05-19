using _3S_project.Data;
using _3S_project.GUI.FormMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _3S_project.GUI.FormAdmin.TaiKhoan
{
    public partial class FormDoiMatKhau : Form
    {
        string tenTk;
        public FormDoiMatKhau(string tentk)
        {
            InitializeComponent();
            tenTk = tentk;
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            {
                string mkc = txtMatKhauCu.Text;
                string mkm = txtMatKhauMoi.Text;
                string nlmk = txtNhapLaiMatKhau.Text;
                isvalid_DoiMatKhau(mkm);
                if (string.IsNullOrWhiteSpace(tenTk))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(mkc))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(mkm))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(nlmk))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.Compare(mkc, mkm) == 0)
                {
                    MessageBox.Show("Mật khẩu cũ và mật khẩu mới trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.Compare(mkm, nlmk) != 0)
                {
                    MessageBox.Show("Mật khẩu mới không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else if (isvalid_DoiMatKhau(mkm) == true)
                {
                    var dataTK = new Data.TaiKhoan();
                    Model.TaiKhoan tk = dataTK.kiemTraDangNhap(tenTk, mkc);
                    if (tk == null)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var dtTK = new Data.TaiKhoan();
                        dtTK.DoiMatKhau(txtTenTaiKhoan.Text, txtMatKhauMoi.Text);
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tối thiểu tám ký tự, ít nhất một chữ cái, một số và một ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public bool isvalid_DoiMatKhau(string txt)
        {
            Regex check = new Regex(@"^(?=.[A-Za-z])(?=.\d)[A-Za-z\d]{8,}$");
            bool value = false;
            value = check.IsMatch(txt);
            if (value == true)
            {
                return value;
            }
            else
            {

                return true;
                //return value;
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
