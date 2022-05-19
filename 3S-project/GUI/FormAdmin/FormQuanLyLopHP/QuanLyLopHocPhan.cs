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
    public partial class QuanLyLopHocPhan : Form
    {
        public QuanLyLopHocPhan()
        {
            InitializeComponent();
            QuanLyLopHocPhan_Load();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            QLLHPthem frmQLLHPthem = new QLLHPthem();
            frmQLLHPthem.ShowDialog();
            QuanLyLopHocPhan_Load();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView5.CurrentRow;
            LopHocPhan lophp = (LopHocPhan)selectedRow.DataBoundItem;
            QLLHP_QLSV frmQLLHP_QLSV = new QLLHP_QLSV(lophp);
            frmQLLHP_QLSV.ShowDialog();
        }

        private void QuanLyLopHocPhan_Load()
        {
            dataLopHocPhan dtLopHocPhan = new dataLopHocPhan();

            List<LopHocPhan> lst = dtLopHocPhan.getlstLopHocPhan();
            bsQuanLyLopHP.DataSource = lst;


            // Hiển thị lên GUI / grid
            maLopHocPhan.DataPropertyName = "MaLopHocPhan";
            hocKi.DataPropertyName = "HocKi";
            namHoc.DataPropertyName = "NamHoc";
            monHoc1.DataPropertyName = "TenMonHoc";
            giangVien1.DataPropertyName = "TenGiangVien";

            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.DataSource = bsQuanLyLopHP;
        }
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DataGridViewRow selectedRow = dataGridView5.Rows[e.RowIndex];
                LopHocPhan lopHocPhan = (LopHocPhan)selectedRow.DataBoundItem;

                frmXoaLHP frmXoaLHP = new frmXoaLHP(lopHocPhan);
                frmXoaLHP.ShowDialog();

                QuanLyLopHocPhan_Load();
            }

            if (dataGridView5.Columns[e.ColumnIndex].Name == "Sua")
            {
                DataGridViewRow selectedRow = dataGridView5.Rows[e.RowIndex];
                LopHocPhan lopHocPhan = (LopHocPhan)selectedRow.DataBoundItem;

                frmSuaLHP frmSuaLHP = new frmSuaLHP(lopHocPhan);
                frmSuaLHP.ShowDialog();

                QuanLyLopHocPhan_Load();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataLopHocPhan dataLopHocPhan = new dataLopHocPhan();
            bsQuanLyLopHP.DataSource = dataLopHocPhan.getlstLopHocPhan(textBox5.Text);
            dataGridView5.AutoGenerateColumns = false;

            dataGridView5.DataSource = bsQuanLyLopHP;
        }
    }
  }
