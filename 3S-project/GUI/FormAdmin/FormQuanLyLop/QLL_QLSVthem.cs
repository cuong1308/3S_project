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
    public partial class QLL_QLSVthem : Form
    {
        int maLop;
        public QLL_QLSVthem(int maLop)
        {
            this.maLop = maLop;
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Nam");
            list.Add("Nữ");
            cbxGioiTinh.DataSource = list;
            dataLop dtLop = new dataLop();
        }

        private void QLL_QLSVthem_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenSinhVien = txtTenSinhVien.Text.Trim();
            DateTime dateTime = dtpNgaySinh.Value;
            bool gioiTinh = false;
            if (cbxGioiTinh.Text == "Nam")
            {
                gioiTinh = true;
            }
            string diaChi = txtDiaChi.Text.Trim();

            //Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(tenSinhVien) || string.IsNullOrWhiteSpace(diaChi) )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            // 3. Thực hiện lưu lên csdl
            dataSinhVien dtSinhVien = new dataSinhVien();
            if (dtSinhVien.Them(tenSinhVien, gioiTinh, dateTime, diaChi,maLop))
            {
                MessageBox.Show("Thêm thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thông tin sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
