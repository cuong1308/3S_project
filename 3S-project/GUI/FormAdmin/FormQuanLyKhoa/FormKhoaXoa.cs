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
    public partial class FormKhoaXoa : Form
    {
        int maKhoa;
        public FormKhoaXoa(Khoa k)
        {
            InitializeComponent();
            maKhoa = k.MaKhoa;
            bsXoaKhoa.DataSource = k;
            dataGridView1.DataSource = bsXoaKhoa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataKhoa dtKhoa = new dataKhoa();
            if (dtKhoa.Xoa(maKhoa))
            {
                MessageBox.Show("Xoá thông tin khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoá thông tin khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
