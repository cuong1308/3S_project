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

namespace _3S_project.GUI.FormAdmin.FormMonHoc
{
    public partial class frmXoaMH : Form
    {
        MonHoc monHoc;
        public frmXoaMH(MonHoc monHoc)
        {
            this.monHoc = monHoc;
            List<MonHoc> lst = new List<MonHoc>();
            lst.Add(monHoc);
            InitializeComponent();
            bsXoaMH.DataSource = lst[0];
            dataGridView1.DataSource = bsXoaMH;
        }

        private void frmXoaMH_Load(object sender, EventArgs e)
        {
            dataMonHoc dtMH = new dataMonHoc();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataMonHoc dtMonHoc = new dataMonHoc();
            if (dtMonHoc.Xoa(monHoc.MaMonHoc))
            {
                MessageBox.Show("Xoá thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoá thông tin môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
