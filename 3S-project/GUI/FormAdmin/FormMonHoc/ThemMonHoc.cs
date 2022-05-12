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

            string tenMonHoc = txtTenMH.Text;
            string DVPT = cboDVPT.Text;
            //int maKhoa = selectedNXB.MaKhoa;
            string tinChi = txtTC.Text;

            // 2. Thành lập đối tượng 
            MonHoc x = new MonHoc();

            x.TenMonHoc = tenMonHoc;


            // 3. Thực hiện lưu lên csdl
            dataMonHoc dtMonHoc = new dataMonHoc();
            dtMonHoc.Them(x.TenMonHoc,DVPT,int.Parse(tinChi));

            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cboDVPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
