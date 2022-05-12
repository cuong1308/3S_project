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
        }

        private void FormQuanLyKhoa_Load(object sender, EventArgs e)
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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Xoá quyển sách đang được chọn trên grid
                    // 1. Xác định sach đang được chọn
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                    Khoa khoa = (Khoa)selectedRow.DataBoundItem;

                    // 2. Thực hiện xoá bizSach.Xoa(sach)
                    dataKhoa dtKhoa = new dataKhoa();
                    dtKhoa.Xoa(khoa.MaKhoa);

                    // Xoá đối tượng Sach khỏi grid
                    bsQuanLyKhoa.RemoveCurrent();

                }
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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormKhoaNew frmKhoaNew = new FormKhoaNew();
            frmKhoaNew.ShowDialog();

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
}
