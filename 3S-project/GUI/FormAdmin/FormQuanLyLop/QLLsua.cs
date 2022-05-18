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

namespace _3S_project.GUI.FormQuanLyLop
{
    public partial class QLLsua : Form
    {
        int maLop;
        public QLLsua(Model.Lop lop)
        {
            InitializeComponent();
            maLop = lop.MaLop;
            dataKhoa dtKhoa = new dataKhoa();
            var lstKhoa = dtKhoa.getlstKhoa();
            cbxKhoa.DataSource = lstKhoa;
            cbxKhoa.DisplayMember = "TenKhoa";
            if(lop.Khoa.TenKhoa == null)
            {
                cbxKhoa.SelectedIndex = 0;

            }
            else
            {
                int count = 0;
                foreach (Khoa k in lstKhoa)
                {
                    if (lop.Khoa.MaKhoa == k.MaKhoa)
                    {
                        break;
                    }

                    else
                        count++;

                }
                cbxKhoa.SelectedIndex = count;

            }

            txtTenLop.Text = lop.TenLop;
            txtKhoaHoc.Text = lop.KhoaHoc;

        }

        private void QLLsua_Load(object sender, EventArgs e)
        {

        }

        private void dongy_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();
            string khoaHoc = txtKhoaHoc.Text.Trim();
            Khoa khoa = (Khoa)cbxKhoa.SelectedItem;
            //Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(tenLop) || string.IsNullOrWhiteSpace(khoaHoc) || string.IsNullOrWhiteSpace(cbxKhoa.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Thực hiện lưu lên csdl
            dataLop dtLop = new dataLop();
            if (dtLop.Sua(maLop, tenLop, khoaHoc, khoa.MaKhoa))
            {
                MessageBox.Show("Sửa thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thông tin lớp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
