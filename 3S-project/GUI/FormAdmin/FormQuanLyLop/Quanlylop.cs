using _3S_project.Data;
using _3S_project.GUI.FormAdmin.FormQuanLyLop;
using _3S_project.GUI.FormAdmin.FormSinhVien;
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
    public partial class Quanlylop : Form
    {
        public Quanlylop()
        {
            InitializeComponent();
            FormQuanlylop_Load();
        }
        private void FormQuanlylop_Load()
        {
            dataLop dtLop = new dataLop();

            List<Lop> lst = dtLop.getlstLop();
            bsQLLop.DataSource = lst;


            // Hiển thị lên GUI / grid
            maLop.DataPropertyName = "MaLop";
            tenLop.DataPropertyName = "TenLop";
            tenKhoa1.DataPropertyName = "TenKhoa";
            khoaHoc.DataPropertyName = "KhoaHoc";


            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = bsQLLop;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView3.CurrentRow;
            Lop lop = (Lop)selectedRow.DataBoundItem;
            QLLQLSV frmQLSV = new QLLQLSV(lop);
            frmQLSV.ShowDialog();

        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            QLLthem frmQLLthem = new QLLthem();
            frmQLLthem.ShowDialog();
            FormQuanlylop_Load();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "Xoa1")
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                Lop lop = (Lop)selectedRow.DataBoundItem;

                QLL_xoa frmXLop = new QLL_xoa(lop);
                frmXLop.ShowDialog();

                FormQuanlylop_Load();
            }

            if (dataGridView3.Columns[e.ColumnIndex].Name == "Sua1")
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                Lop lop = (Lop)selectedRow.DataBoundItem;

                QLLsua frmLop = new QLLsua(lop);
                frmLop.ShowDialog();

                FormQuanlylop_Load();
            }
        }



        private void Quanlylop_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataLop dataLop = new dataLop();
            bsQLLop.DataSource = dataLop.getlstLop(textBox3.Text);
            dataGridView3.AutoGenerateColumns = false;

            dataGridView3.DataSource = bsQLLop;
        }
    }
}
