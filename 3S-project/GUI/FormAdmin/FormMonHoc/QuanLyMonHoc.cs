using _3S_project.Data;
using _3S_project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI.FormAdmin.FormMonHoc
{
    public partial class frmQuanLyMonHoc : Form
    {
        public frmQuanLyMonHoc()
        {
            InitializeComponent();
            frmQuanLyMonHoc_Load();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyMonHoc_Load()
        {
            dataMonHoc dtMH = new dataMonHoc();

            List<MonHoc> lst = dtMH.getlstMonHoc();
            bindingQuanLyMonHoc.DataSource = lst;


            // Hiển thị lên GUI / grid
            maMonHoc.DataPropertyName = "MaMonHoc";
            tenMonHoc.DataPropertyName = "TenMonHoc";
            DVPT.DataPropertyName = "DonViPhuTrach";
            tinChi.DataPropertyName = "TinChi";

            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.DataSource = bindingQuanLyMonHoc;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmThemMonHoc frThemMoiSV = new frmThemMonHoc();
            frThemMoiSV.ShowDialog();

            dataMonHoc dtMH = new dataMonHoc();

            List<MonHoc> lst = dtMH.getlstMonHoc();
            bindingQuanLyMonHoc.DataSource = lst;


            // Hiển thị lên GUI / grid
            maMonHoc.DataPropertyName = "MaMonHoc";
            tenMonHoc.DataPropertyName = "TenMonHoc";
            DVPT.DataPropertyName = "DonViPhuTrach";
            tinChi.DataPropertyName = "TinChi";

            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.DataSource = bindingQuanLyMonHoc;
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView6.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DataGridViewRow selectedRow = dataGridView6.Rows[e.RowIndex];
                MonHoc monHoc = (MonHoc)selectedRow.DataBoundItem;

                frmXoaMH frmXMH = new frmXoaMH(monHoc);
                frmXMH.ShowDialog();

                dataMonHoc dtMH = new dataMonHoc();

                List<MonHoc> lst = dtMH.getlstMonHoc();
                bindingQuanLyMonHoc.DataSource = lst;


                // Hiển thị lên GUI / grid
                maMonHoc.DataPropertyName = "MaMonHoc";
                tenMonHoc.DataPropertyName = "TenMonHoc";
                DVPT.DataPropertyName = "DonViPhuTrach";
                tinChi.DataPropertyName = "TinChi";

                dataGridView6.AutoGenerateColumns = false;
                dataGridView6.DataSource = bindingQuanLyMonHoc;
            }

            if (dataGridView6.Columns[e.ColumnIndex].Name == "Sua")
            {
                DataGridViewRow selectedRow = dataGridView6.Rows[e.RowIndex];
                MonHoc monHoc = (MonHoc)selectedRow.DataBoundItem;

                frmSuaMonHoc frmSMH = new frmSuaMonHoc(monHoc);
                frmSMH.ShowDialog();

                dataMonHoc dtMH = new dataMonHoc();

                List<MonHoc> lst = dtMH.getlstMonHoc();
                bindingQuanLyMonHoc.DataSource = lst;


                // Hiển thị lên GUI / grid
                maMonHoc.DataPropertyName = "MaMonHoc";
                tenMonHoc.DataPropertyName = "TenMonHoc";
                DVPT.DataPropertyName = "DonViPhuTrach";
                tinChi.DataPropertyName = "TinChi";

                dataGridView6.AutoGenerateColumns = false;
                dataGridView6.DataSource = bindingQuanLyMonHoc;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataMonHoc dtMH = new dataMonHoc();

            List<MonHoc> lst = dtMH.getlstMonHoc(textBox6.Text);
            bindingQuanLyMonHoc.DataSource = lst;

            dataGridView6.AutoGenerateColumns = false;
            dataGridView6.DataSource = bindingQuanLyMonHoc;
        }
    }
}
