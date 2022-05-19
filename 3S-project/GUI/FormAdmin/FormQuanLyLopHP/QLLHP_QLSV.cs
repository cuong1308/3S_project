using _3S_project.Data;
using _3S_project.GUI.FormAdmin.FormQuanLyLopHP;
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
    public partial class QLLHP_QLSV : Form
    {
        string maLopHocPhan;
        public QLLHP_QLSV(Model.LopHocPhan lophp)
        {
            InitializeComponent();
            txtQLSV.Text = txtQLSV.Text + " lớp " + lophp.TenLopHocPhan;
            maLopHocPhan = lophp.MaLopHocPhan.ToString();
            LoadSV();
        }
        private void LoadSV()
        {
            dataSinhVien dataSinhVien = new dataSinhVien();
            bsQuanLySinhVien.DataSource = dataSinhVien.getlstSinhVien_LopHocPhan(maLopHocPhan,"","");
            dataGridView4.AutoGenerateColumns = false;

            dataGridView4.DataSource = bsQuanLySinhVien;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataSinhVien dataSinhVien = new dataSinhVien();
            bsQuanLySinhVien.DataSource = dataSinhVien.getlstSinhVien_LopHocPhan(maLopHocPhan, textBox1.Text, textBox2.Text);
            dataGridView4.AutoGenerateColumns = false;

            dataGridView4.DataSource = bsQuanLySinhVien;
        }

        private void themsv_Click(object sender, EventArgs e)
        {
            QLLHP_addSV qLLHP_AddSV = new QLLHP_addSV(maLopHocPhan);
            qLLHP_AddSV.ShowDialog();
            LoadSV();
        }
        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void xoasv_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView4.CurrentRow;
            LopHocPhan lophp = (LopHocPhan)selectedRow.DataBoundItem;
            QLLHP_QLSV frmQLLHP_QLSV = new QLLHP_QLSV(lophp);
            frmQLLHP_QLSV.ShowDialog();
        }
    }
}
