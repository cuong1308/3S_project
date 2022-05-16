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

namespace _3S_project.GUI.FormAdmin.FormQuanLyKhoa
{
    public partial class FormQuanLyKhoa : Form
    {
        public FormQuanLyKhoa()
        {
            InitializeComponent();
            FormQuanLyKhoa_Load();
        }

        private void FormQuanLyKhoa_Load()
        {
            dataKhoa dtKhoa = new dataKhoa();

            List<Khoa> lst = dtKhoa.getlstKhoa();
            bsQuanLyKhoa.DataSource = lst;


            // Hiển thị lên GUI / grid
            maKhoa.DataPropertyName = "MaKhoa";
            tenKhoa.DataPropertyName = "TenKhoa";

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = bsQuanLyKhoa;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "xoa3")
            {
                
                    // Xoá quyển sách đang được chọn trên grid
                    // 1. Xác định sach đang được chọn
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                    Khoa khoa = (Khoa)selectedRow.DataBoundItem;

                // 2. Thực hiện xoá bizSach.Xoa(sach)
                FormKhoaXoa formKhoaXoa = new FormKhoaXoa(khoa);

                FormQuanLyKhoa_Load();

                
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "sua3")

            {
                    // Xác định đối tượng đang chọn
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                    Khoa khoa = (Khoa)selectedRow.DataBoundItem;

                    FormKhoaSua frmSua = new FormKhoaSua(khoa);
                frmSua.ShowDialog();

                dataKhoa dtKhoa = new dataKhoa();

                List<Khoa> lst = dtKhoa.getlstKhoa();
                bsQuanLyKhoa.DataSource = lst;


                // Hiển thị lên GUI / grid
                maKhoa.DataPropertyName = "MaKhoa";
                tenKhoa.DataPropertyName = "TenKhoa";



                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = bsQuanLyKhoa;



            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataKhoa dtKhoa = new dataKhoa();

            List<Khoa> lst = dtKhoa.getlstKhoa(textBox2.Text);
            bsQuanLyKhoa.DataSource = lst;

            // Hiển thị lên GUI / grid
            maKhoa.DataPropertyName = "MaKhoa";
            tenKhoa.DataPropertyName = "TenKhoa";

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = bsQuanLyKhoa;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormKhoaNew frmKhoaNew = new FormKhoaNew();
            frmKhoaNew.ShowDialog();

            FormQuanLyKhoa_Load();

        }
    }
}
