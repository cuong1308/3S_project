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
    public partial class QLL_QLSVsua : Form
    {
        int maSinhVien;
        public QLL_QLSVsua(Model.SinhVien sinhVien)
        {
            InitializeComponent();
            maSinhVien = sinhVien.MaSinhVien;
            List<string> list = new List<string>();
            list.Add("Nam");
            list.Add("Nữ");
            cbxGioiTinh.DataSource = list;
            dataLop dtLop = new dataLop();
            var lstLop = dtLop.getlstLop();
            cbxLop.DataSource = lstLop;
            cbxLop.DisplayMember = "TenLop";
            int count = 0;
            foreach (Lop l in lstLop)
            {
                if (sinhVien.Lop.MaLop == l.MaLop)
                {
                    break;
                }

                else
                    count++;

            }

            txtTenSinhVien.Text = sinhVien.TenSinhVien;
            dtpNgaySinh.Value = sinhVien.DateTime;
            if (sinhVien.GioiTinh == false)
                cbxGioiTinh.SelectedIndex = 1;
            else
                cbxGioiTinh.SelectedIndex = 0;
            txtDiaChi.Text = sinhVien.DiaChi;
            cbxLop.SelectedIndex = count;
        }

        private void QLL_QLSVsua_Load(object sender, EventArgs e)
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
            Lop lop = (Lop)cbxLop.SelectedItem;

            //Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(tenSinhVien) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(cbxLop.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            // 3. Thực hiện lưu lên csdl
            dataSinhVien dtSinhVien = new dataSinhVien();
            if (dtSinhVien.Sua(maSinhVien, tenSinhVien, gioiTinh, dateTime, diaChi, lop.MaLop))
            {
                MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thông tin sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
