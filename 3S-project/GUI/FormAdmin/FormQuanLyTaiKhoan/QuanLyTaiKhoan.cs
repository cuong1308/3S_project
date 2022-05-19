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

namespace _3S_project.GUI.FormAdmin.FormQuanLyTaiKhoan
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadTk();
        }
        private void LoadTk()
        {
            Data.TaiKhoan taiKhoan = new Data.TaiKhoan();
            bsQuanLyTaiKhoan.DataSource = taiKhoan.getlstTaiKhoan("");
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bsQuanLyTaiKhoan;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Kích hoạt" : "Đã vô hiệu hoá";
                    e.FormattingApplied = true;
                }
            }
            if(e.ColumnIndex == 2)
            {
                if (e.Value is int)
                {
                    int value = (int)e.Value;
                    if(value == 1)
                    {
                        e.Value = "Admin";
                    }
                    else if(value == 2)
                    {
                        e.Value = "Quản lý";
                    }else if(value == 3)
                    {
                        e.Value = "Giảng viên";
                    }

                    
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "tinhTrang")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Model.TaiKhoan tk = (Model.TaiKhoan)selectedRow.DataBoundItem;

                Data.TaiKhoan taiKhoandata = new Data.TaiKhoan();
                if (taiKhoandata.KichHoat_VoHieuHoa(tk.TrangThai, tk.TenUser))
                {
                    MessageBox.Show("Thao tác thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                LoadTk();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "sua")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Model.TaiKhoan tk = (Model.TaiKhoan)selectedRow.DataBoundItem;
                SuaTaiKhoan taiKhoan = new SuaTaiKhoan(tk);
                taiKhoan.ShowDialog();
                LoadTk();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "phanQuyen")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Model.TaiKhoan tk = (Model.TaiKhoan)selectedRow.DataBoundItem;
                PhanQuyen phanQuyen = new PhanQuyen(tk);
                phanQuyen.ShowDialog();
                LoadTk();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data.TaiKhoan taiKhoan = new Data.TaiKhoan();
            bsQuanLyTaiKhoan.DataSource = taiKhoan.getlstTaiKhoan(textBox1.Text);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bsQuanLyTaiKhoan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan themTaiKhoan = new ThemTaiKhoan();
            themTaiKhoan.ShowDialog();
            this.LoadTk();
        }
    }
}
