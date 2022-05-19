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

namespace _3S_project.GUI.FormAdmin.FormSinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            LoadSV();
        }
        private void LoadSV()
        {
            dataSinhVien dataSinhVien = new dataSinhVien();
            bsQuanLySinhVien.DataSource = dataSinhVien.getlstSinhVien();
            dataGridView4.AutoGenerateColumns = false;

            dataGridView4.DataSource = bsQuanLySinhVien;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataSinhVien dataSinhVien = new dataSinhVien();
            bsQuanLySinhVien.DataSource = dataSinhVien.getlstSinhVien(textBox4.Text);
            dataGridView4.AutoGenerateColumns = false;

            dataGridView4.DataSource = bsQuanLySinhVien;
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

        private void button12_Click(object sender, EventArgs e)
        {
            ThemSinhVien themSinhVien = new ThemSinhVien();
            themSinhVien.ShowDialog();
            LoadSV();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DataGridViewRow selectedRow = dataGridView4.Rows[e.RowIndex];
                SinhVien sinhVien = (SinhVien)selectedRow.DataBoundItem;

                XoaSV frmXSV = new XoaSV(sinhVien);
                frmXSV.ShowDialog();

                LoadSV();
            }

            if (dataGridView4.Columns[e.ColumnIndex].Name == "Sua")
            {
                DataGridViewRow selectedRow = dataGridView4.Rows[e.RowIndex];
                SinhVien sinhVien = (SinhVien)selectedRow.DataBoundItem;

                SuaSV frmSSV = new SuaSV(sinhVien);
                frmSSV.ShowDialog();

                LoadSV();
            }
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
