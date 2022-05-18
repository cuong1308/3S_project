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
    public partial class QLL_QLSVxoa : Form
    {
        int maSinhVien;
        public QLL_QLSVxoa(Model.SinhVien sinhVien)
        {            
            maSinhVien = sinhVien.MaSinhVien;
            InitializeComponent();
            List<SinhVien> lst = new List<SinhVien>();
            lst.Add(sinhVien);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lst;
        }

        private void QLL_QLSVxoa_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 3. Thực hiện lưu lên csdl
            dataSinhVien dtSinhVien = new dataSinhVien();
            if (dtSinhVien.Xoa(maSinhVien))
            {
                MessageBox.Show("Xoá thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Xoá thông tin sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
