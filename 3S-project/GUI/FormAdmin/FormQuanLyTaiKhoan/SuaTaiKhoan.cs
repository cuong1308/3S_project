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

namespace _3S_project.GUI.FormAdmin.FormQuanLyTaiKhoan
{
    public partial class SuaTaiKhoan : Form
    {
        string tk;
        public SuaTaiKhoan(Model.TaiKhoan taiKhoan)
        {
            tk = taiKhoan.TenUser;
            InitializeComponent();
            dataGiangVien dataGiangVien = new dataGiangVien();
            var lstGV = dataGiangVien.getlstGiangVien();
            lstGV.Insert(0, new Model.GiangVien() { TenGiangVien = "Không",MaGiangVien = 0 });
            cbxGiangVien.DataSource = lstGV;
            cbxGiangVien.DisplayMember = "TenGiangVien"; int count = 0;
            foreach (GiangVien gv in lstGV)
            {
                if (taiKhoan.GiangVien.MaGiangVien == gv.MaGiangVien)
                {
                    break;
                }

                else
                    count++;

            }
            cbxGiangVien.SelectedIndex = count;
            txtEmail.Text = taiKhoan.Email;
            txtPass.Text = taiKhoan.MatKhau;
            txtPassConf.Text = taiKhoan.MatKhau;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiangVien giangVien = (GiangVien)cbxGiangVien.SelectedItem;
            string email = txtEmail.Text.Trim();
            string pass = txtPass.Text;
            string passconf = txtPassConf.Text;


            //Kiểm tra tính hợp lệ của dữ liệu
            if ( string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(passconf))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            // 3. Thực hiện lưu lên csdl
            Data.TaiKhoan dtTK = new Data.TaiKhoan();
            if (giangVien.TenGiangVien != "Không")
            {
                if (pass == passconf)
                {

                    if (dtTK.Sua(tk, giangVien.MaGiangVien.ToString(), 3, pass, email))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (pass == passconf)
                {
                    if (dtTK.Sua(tk, "0", 2, pass, email))
                    {
                        MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
