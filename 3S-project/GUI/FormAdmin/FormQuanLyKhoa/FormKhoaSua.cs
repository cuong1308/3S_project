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
            dataKhoa dataKhoa = new dataKhoa();
            dataKhoa.Sua(int.Parse( label4.Text), textBox1.Text);
            this.Close();
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
