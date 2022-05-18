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

namespace _3S_project.GUI.FormAdmin.FormQuanLyLop
{
    public partial class QLL_xoa : Form
    {
        int maLop;
        public QLL_xoa(Model.Lop lop)
        {
            maLop = lop.MaLop;
            InitializeComponent();
            List<Lop> lst = new List<Lop>();
            lst.Add(lop);
            gridLop.AutoGenerateColumns = false;
            gridLop.DataSource = lst;
        }

        private void QLL_xoa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataLop dtLop = new dataLop();
            if (dtLop.Xoa(maLop))
            {
                MessageBox.Show("Xoá thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoá thông tin lớp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
