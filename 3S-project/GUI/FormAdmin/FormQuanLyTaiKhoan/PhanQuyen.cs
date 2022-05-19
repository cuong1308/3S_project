using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI.FormAdmin.FormQuanLyTaiKhoan
{
    public partial class PhanQuyen : Form
    {
        Model.TaiKhoan tk;
        public PhanQuyen(Model.TaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
            label2.Text = tk.TenUser;
            List<string> list = new List<string>();
            list.Add("Admin");
            list.Add("Quản lý");
            list.Add("Giảng viên");
            comboBox1.DataSource = list;
            comboBox1.SelectedIndex = tk.Quyen - 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quyen = 0;
            if ((string)comboBox1.SelectedItem == "Admin")
                quyen = 1;
            else if ((string)comboBox1.SelectedItem == "Quản lý")
                quyen = 2;
            else if ((string)comboBox1.SelectedItem == "Giảng viên")
                quyen = 3;
            Data.TaiKhoan taiKhoan = new Data.TaiKhoan();
            if (taiKhoan.Sua(tk.TenUser, tk.GiangVien.MaGiangVien.ToString(), quyen, tk.MatKhau, tk.Email))
            {
                MessageBox.Show("Phân quyền cho tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Phân quyền cho tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
