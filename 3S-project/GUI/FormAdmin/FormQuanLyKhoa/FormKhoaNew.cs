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

namespace _3S_project.GUI.FormAdmin.FormQuanLyKhoa
{
    public partial class FormKhoaNew : Form
    {
        public Khoa InsertedKhoa { get; private set; }

        public FormKhoaNew()
        {
            InitializeComponent();
        }

        private void FormKhoaNew_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI

            string tenKhoa = txtTenKhoa.Text.Trim();

            // 2. Thành lập đối tượng sach

            //Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(tenKhoa))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Thực hiện lưu lên csdl
            dataKhoa dtKhoa = new dataKhoa();
            if (dtKhoa.Them(tenKhoa))
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
    }
}
