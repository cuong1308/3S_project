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

namespace _3S_project.GUI.FormAdmin.QuanLyGiangVien
{
    public partial class FormXoaGV : Form
    {
        public FormXoaGV()
        {
            InitializeComponent();
        }
        public FormXoaGV(Model.GiangVien giangVien)
        {
            InitializeComponent();
            label3.Text = giangVien.MaGiangVien.ToString();
            label4.Text = giangVien.TenGiangVien.ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dataGiangVien dataGV = new dataGiangVien();
            dataGV.Xoa(int.Parse(label3.Text));
            MessageBox.Show("Xoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FormXoaGV_Load(object sender, EventArgs e)
        {

        }
    }
}
