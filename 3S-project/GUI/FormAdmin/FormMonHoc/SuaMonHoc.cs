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
            txtTC.Text = monHoc.TinChi.ToString();

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

            string tenMonHoc = txtTenMH.Text;
            string DVPT = cboDVPT.Text;
            //int maKhoa = selectedNXB.MaKhoa;
            string tinChi = txtTC.Text;

            // 2. Thành lập đối tượng 
            MonHoc x = new MonHoc();

            x.TenMonHoc = tenMonHoc;


            // 3. Thực hiện lưu lên csdl
            dataMonHoc dtMonHoc = new dataMonHoc();
            dtMonHoc.Sua(monHoc.MaMonHoc,x.TenMonHoc, DVPT, int.Parse(tinChi));
            this.Close();
        }
    }
}
