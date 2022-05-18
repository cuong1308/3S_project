using _3S_project.Data;
using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI.FormAdmin.QuanLyGiangVien
{
    public partial class FormGV : Form
    {
        public FormGV()
        {
            InitializeComponent();
            FormGV_Load();
        }

        private void FormGV_Load()
        {
            dataGiangVien dtGV = new dataGiangVien();

            List<GiangVien> lst = dtGV.getlstGiangVien();
            bsGiangVien.DataSource = lst;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bsGiangVien;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            FormThemGV frm = new FormThemGV();
            frm.ShowDialog();


            dataGiangVien dtGV = new dataGiangVien();

            List<GiangVien> lst = dtGV.getlstGiangVien();
            bsGiangVien.DataSource = lst;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bsGiangVien;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colXoa")
            {                  
                    // Xoá quyển sách đang được chọn trên grid
                    // 1. Xác định sach đang được chọn
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    GiangVien gv = (GiangVien)selectedRow.DataBoundItem;

                    FormXoaGV frmXoa = new FormXoaGV(gv);
                    frmXoa.ShowDialog();
                    FormGV_Load();


            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colSua")

            {
                // Xác định đối tượng đang chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                GiangVien giangVien = (GiangVien)selectedRow.DataBoundItem;

                FormSuaGV frmSua = new FormSuaGV(giangVien);
                frmSua.ShowDialog();

                FormGV_Load();


            }
        }
        public bool IsNumber(string txt)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(txt);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtGiangVien_TextChanged(object sender, EventArgs e)
        {
            dataGiangVien dtGV = new dataGiangVien();

            List<GiangVien> lst = dtGV.getlstGiangVien(txtGiangVien.Text);
            bsGiangVien.DataSource = lst;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bsGiangVien;
        }
    }
}