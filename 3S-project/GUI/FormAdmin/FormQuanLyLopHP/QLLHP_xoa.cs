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

namespace _3S_project.GUI.FormAdmin.FormQuanLyLopHP
{
    public partial class frmXoaLHP : Form
    {
        int MaLopHocPhan;
        public frmXoaLHP(Model.LopHocPhan lopHocPhan)
        {
            InitializeComponent();
                MaLopHocPhan = lopHocPhan.MaLopHocPhan;
                List<LopHocPhan> lst = new List<LopHocPhan>();
                lst.Add(lopHocPhan);
                dataGridView5.AutoGenerateColumns = false;
                dataGridView5.DataSource = lst;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dataLopHocPhan dtLopHocPhan = new dataLopHocPhan();
            if (dtLopHocPhan.Xoa(MaLopHocPhan))
            {
                MessageBox.Show("Xoá lớp học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoá lớp học phần thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
