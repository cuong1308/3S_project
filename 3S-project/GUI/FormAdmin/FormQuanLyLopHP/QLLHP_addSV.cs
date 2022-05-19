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

namespace _3S_project.GUI.FormAdmin.FormQuanLyLopHP
{
    public partial class QLLHP_addSV : Form
    {
        string maLopHocPhan;
        public QLLHP_addSV(string maLopHocPhan)
        {
            InitializeComponent();
            this.maLopHocPhan = maLopHocPhan;
            LoadSV();
        }
        private void LoadSV()
        {
            dataSinhVien dataSinhVien = new dataSinhVien();
            bsQuanLySinhVien.DataSource = dataSinhVien.getlstSinhVien_expLopHocPhan(maLopHocPhan, "", "");
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
    }
}
