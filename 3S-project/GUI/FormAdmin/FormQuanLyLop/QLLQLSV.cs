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
    public partial class QLLQLSV : Form
    {
        int maLop;
        public QLLQLSV(Lop lop)
        {
            maLop = lop.MaLop;
            InitializeComponent();
            QLSV_Load();
        }

        private void QLSV_Load()
        {

            dataSinhVien dtSinhVien = new dataSinhVien();
            bsQLSVLop.DataSource = dtSinhVien.getlstSinhVien_Lop(maLop);
            gridSinhVien.AutoGenerateColumns = false;

            gridSinhVien.DataSource = bsQLSVLop;
        }

        private void QLLQLSV_Load(object sender, EventArgs e)
        {

        }

        private void txtQLSVLop_TextChanged(object sender, EventArgs e)
        {
            dataSinhVien dataSinhVien = new dataSinhVien();
            bsQLSVLop.DataSource = dataSinhVien.getlstSinhVien_Lop(txtQLSVLop.Text,maLop);
            gridSinhVien.AutoGenerateColumns = false;

            gridSinhVien.DataSource = bsQLSVLop;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QLL_QLSVthem themSinhVien = new QLL_QLSVthem(maLop);
            themSinhVien.ShowDialog();
            QLSV_Load();
        }

        private void gridSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSinhVien.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DataGridViewRow selectedRow = gridSinhVien.Rows[e.RowIndex];
                SinhVien sinhVien = (SinhVien)selectedRow.DataBoundItem;

                QLL_QLSVxoa frmXSV = new QLL_QLSVxoa(sinhVien);
                frmXSV.ShowDialog();

                QLSV_Load();
            }

            if (gridSinhVien.Columns[e.ColumnIndex].Name == "Sua")
            {
                DataGridViewRow selectedRow = gridSinhVien.Rows[e.RowIndex];
                SinhVien sinhVien = (SinhVien)selectedRow.DataBoundItem;

                QLL_QLSVsua frmSSV = new QLL_QLSVsua(sinhVien);
                frmSSV.ShowDialog();

                QLSV_Load();
            }
        }
    }
}
