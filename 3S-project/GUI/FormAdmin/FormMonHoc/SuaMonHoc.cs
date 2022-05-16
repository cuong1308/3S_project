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
    public partial class frmSuaMonHoc : Form
    {
        MonHoc monHoc;
        public frmSuaMonHoc(MonHoc monHoc)
        {
            InitializeComponent();
            this.monHoc = monHoc;
            txtTenMH.Text = monHoc.TenMonHoc;
            cboDVPT.Text = monHoc.DonViPhuTrach;

            numTinChi.Value = monHoc.TinChi;

            dataKhoa dtKhoa = new dataKhoa();

            List<Khoa> lst = dtKhoa.getlstKhoa();
            cboDVPT.DataSource = lst;
            cboDVPT.DisplayMember = "TenKhoa";
        }

        private void frmSuaMonHoc_Load(object sender, EventArgs e)
        {
            dataMonHoc dtMH = new dataMonHoc();
            List<MonHoc> lst = dtMH.getlstMonHoc();
            bsSuaMH.DataSource = lst;


         
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
            if (dtMonHoc.Sua(monHoc.MaMonHoc,tenMonHoc, DVPT, int.Parse(tinChi)))
            {
                MessageBox.Show("Sửa thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thông tin môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
