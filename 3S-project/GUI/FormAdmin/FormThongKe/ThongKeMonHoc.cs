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

namespace _3S_project.GUI.FormAdmin.FormThongKe
{
    public partial class ThongKeMonHoc : Form
    {
        public ThongKeMonHoc()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Tất cả");
            list.Add("<4");
            list.Add("4 đến 5,5");
            list.Add("5,5 đến 7");
            list.Add("7 đến 8,5");
            list.Add(">8,5");
            cbxTieuChi.DataSource = list;
            dataMonHoc dataLopHocPhan = new dataMonHoc();
            var lstLHP = dataLopHocPhan.getlstMonHoc();
            cbxMonHoc.DataSource = lstLHP;
            cbxMonHoc.DisplayMember = "TenMonHoc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataDiem dataDiem = new dataDiem();
            int maMonHoc = 0;
            MonHoc monHoc = (MonHoc)cbxMonHoc.SelectedItem;
            if (monHoc != null)
            {
                maMonHoc = monHoc.MaMonHoc;
            }
            if (cbxTieuChi.Text == "Tất cả")
                bsMonHoc.DataSource = dataDiem.tkMonHoc("0", "10", maMonHoc);
            else if (cbxTieuChi.Text == "<4")
                bsMonHoc.DataSource = dataDiem.tkMonHoc("0", "4", maMonHoc);
            else if (cbxTieuChi.Text == "4 đến 5,5")
                bsMonHoc.DataSource = dataDiem.tkMonHoc("4", "5.5", maMonHoc);
            else if (cbxTieuChi.Text == "5,5 đến 7")
                bsMonHoc.DataSource = dataDiem.tkMonHoc("5.5", "7", maMonHoc);
            else if (cbxTieuChi.Text == "7 đến 8,5")
                bsMonHoc.DataSource = dataDiem.tkMonHoc("7", "8.5", maMonHoc);
            else if (cbxTieuChi.Text == ">8,5")
                bsMonHoc.DataSource = dataDiem.tkMonHoc("8.5", "10", maMonHoc);
            gridTK.DataSource = bsMonHoc;
        }

        private void ThongKeMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
