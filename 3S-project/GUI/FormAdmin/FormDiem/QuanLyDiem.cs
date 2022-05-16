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

namespace _3S_project.GUI.FormAdmin.FormDiem
{
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
            LoadQLD();
        }
        private void LoadQLD()
        {
            dataDiem dataDiem = new dataDiem();
            bsQuanLyDiem.DataSource = dataDiem.getlstDiem("","","","");
            gridQuanLyBanDiem.AutoGenerateColumns = false;
            gridQuanLyBanDiem.DataSource = bsQuanLyDiem;
        }



        private void gridQuanLyBanDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (gridQuanLyBanDiem.Columns[e.ColumnIndex].Name == "Nhap")
            {
                DataGridViewRow selectedRow = gridQuanLyBanDiem.Rows[e.RowIndex];
                Diem diem = (Diem)selectedRow.DataBoundItem;

                NhapDiem nhapDiem = new NhapDiem(diem);
                nhapDiem.ShowDialog();

                LoadQLD();
            }
        }

        private void txtTenSinhVien_TextChanged(object sender, EventArgs e)
        {
            dataDiem dataDiem = new dataDiem();
            bsQuanLyDiem.DataSource = dataDiem.getlstDiem(txtTenSinhVien.Text, txtTenLopHocPhan.Text, txtTenMonHoc.Text, txtMaSinhVien.Text);
            gridQuanLyBanDiem.AutoGenerateColumns = false;
            gridQuanLyBanDiem.DataSource = bsQuanLyDiem;
        }
    }
}
