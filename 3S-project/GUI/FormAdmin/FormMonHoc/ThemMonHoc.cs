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

namespace _3S_project.GUI.FormAdmin.FormMonHoc
{
    public partial class frmThemMonHoc : Form
    {
        public frmThemMonHoc()
        {
            InitializeComponent();
            // Nạp danh sách các nhà xuất bản vào cbxNhaXuatBan để người dùng có thể chọn
            dataKhoa dtKhoa = new dataKhoa();

            List<Khoa> lst = dtKhoa.getlstKhoa();
            cboDVPT.DataSource = lst;
            cboDVPT.DisplayMember = "TenKhoa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI

            string tenMonHoc = txtTenMH.Text.Trim();
            string DVPT = cboDVPT.Text.Trim();
            //int maKhoa = selectedNXB.MaKhoa;
            string tinChi = numTinChi.Text.Trim();


            //Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(tenMonHoc) || string.IsNullOrWhiteSpace(DVPT) || string.IsNullOrWhiteSpace(tinChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            


            // 3. Thực hiện lưu lên csdl
            dataMonHoc dtMonHoc = new dataMonHoc();
            if(dtMonHoc.Them(tenMonHoc,DVPT,int.Parse(tinChi)))
            {
                MessageBox.Show("Thêm thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thông tin môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboDVPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {

        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
