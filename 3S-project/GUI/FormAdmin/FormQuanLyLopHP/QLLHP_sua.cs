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

namespace _3S_project.GUI.FormQuanLyLop
{
    public partial class frmSuaLHP : Form
    {
        int maLopHocPhan;
        public frmSuaLHP(Model.LopHocPhan lopHocPhan)
        {
            InitializeComponent();
            maLopHocPhan = lopHocPhan.MaLopHocPhan;

            dataMonHoc dataMonHoc = new dataMonHoc();
            cboMH.DataSource = dataMonHoc.getlstMonHoc();
            cboMH.DisplayMember = "TenMonHoc";

            dataGiangVien dataGiangVien = new dataGiangVien();
            cboGv.DataSource = dataGiangVien.getlstGiangVien();
            cboGv.DisplayMember = "TenGiangVien";

            txtTenLHP.Text = lopHocPhan.TenLopHocPhan;
            intHK.Text = lopHocPhan.HocKi.ToString();
            txtNH.Text = lopHocPhan.NamHoc;
        }

        

        private void dongy_Click(object sender, EventArgs e)
        {
            string tenLopHocPhan = txtTenLHP.Text.Trim();
            int hocKi = int.Parse(intHK.Text);
            string namHoc = txtNH.Text;
            MonHoc monHoc = (MonHoc)cboMH.SelectedItem;
            GiangVien giangVien = (GiangVien)cboGv.SelectedItem;

            if (string.IsNullOrWhiteSpace(tenLopHocPhan) || string.IsNullOrWhiteSpace(txtNH.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataLopHocPhan dtLopHocPhan = new dataLopHocPhan();
            if (dtLopHocPhan.Sua(maLopHocPhan, tenLopHocPhan, hocKi, namHoc, monHoc.MaMonHoc, giangVien.MaGiangVien))
            {
                MessageBox.Show("Sửa thông tin lớp học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thông tin lớp học phần thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
