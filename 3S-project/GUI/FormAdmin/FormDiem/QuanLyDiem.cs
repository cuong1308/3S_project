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
            dataLopHocPhan dataLopHocPhan = new dataLopHocPhan();
            cbxLopHocPhan.DataSource = dataLopHocPhan.getlstLopHocPhan();
            cbxLopHocPhan.DisplayMember = "TenLopHocPhan";
            cbxLopHocPhan.SelectedIndex = 0;
            LoadQLD();
        }
        private void LoadQLD()
        {
            dataDiem dataDiem = new dataDiem();
            int maLopHocPhan = 0;
            LopHocPhan lhp = (LopHocPhan)cbxLopHocPhan.SelectedItem;
            maLopHocPhan = lhp.MaLopHocPhan;
            bsQuanLyDiem.DataSource = dataDiem.getlstDiem("",maLopHocPhan,"");
            gridQuanLyBanDiem.AutoGenerateColumns = false;
            gridQuanLyBanDiem.DataSource = bsQuanLyDiem;
        }



        private void gridQuanLyBanDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (gridQuanLyBanDiem.Columns[e.ColumnIndex].Name == "nhap")
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
            int maLopHocPhan = 0;
            LopHocPhan lhp = (LopHocPhan)cbxLopHocPhan.SelectedItem;
            maLopHocPhan = lhp.MaLopHocPhan;
            bsQuanLyDiem.DataSource = dataDiem.getlstDiem(txtTenSinhVien.Text, maLopHocPhan, txtMaSinhVien.Text);
            gridQuanLyBanDiem.AutoGenerateColumns = false;
            gridQuanLyBanDiem.DataSource = bsQuanLyDiem;
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }
    }
}
