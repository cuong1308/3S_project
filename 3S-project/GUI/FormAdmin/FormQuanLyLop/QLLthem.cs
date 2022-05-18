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
    public partial class QLLthem : Form
    {
        public QLLthem()
        {
            InitializeComponent();
            dataKhoa dtKhoa = new dataKhoa();
            cbxKhoa.DataSource = dtKhoa.getlstKhoa();
            cbxKhoa.DisplayMember = "TenKhoa";

        }

        private void QLLthem_Load(object sender, EventArgs e)
        {

        }

        private void dongy_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI

            string tenLop = textBox2.Text.Trim();
            string khoaHoc = textBox3.Text.Trim();
            Khoa khoa = (Khoa)cbxKhoa.SelectedItem;

            // 2. Thành lập đối tượng sach

            //Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(tenLop)|| string.IsNullOrWhiteSpace(khoaHoc))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // 3. Thực hiện lưu lên csdl
            dataLop dtLop = new dataLop();
            if (dtLop.Them(tenLop, khoaHoc, khoa.MaKhoa))
            {
                MessageBox.Show("Thêm thông tin khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thông tin khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
