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

namespace _3S_project.GUI.FormAdmin.FormQuanLyKhoa
{
    public partial class FormKhoaSua : Form
    {
        public FormKhoaSua(Model.Khoa khoa)
        {
            InitializeComponent();
            label4.Text = khoa.MaKhoa.ToString();
            textBox1.Text = khoa.TenKhoa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI

            string tenKhoa = textBox1.Text.Trim();

            // 2. Thành lập đối tượng sach

            //Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(tenKhoa))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Thực hiện lưu lên csdl
            dataKhoa dtKhoa = new dataKhoa();
            if (dtKhoa.Sua(int.Parse(label4.Text),tenKhoa))
            {
                MessageBox.Show("Sửa thông tin khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thông tin khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormKhoaSua_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
