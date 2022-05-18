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
    public partial class ThongKeLop : Form
    {
        public ThongKeLop()
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
            dataLopHocPhan dataLopHocPhan= new dataLopHocPhan();
            var lstLHP = dataLopHocPhan.getlstLopHocPhan();
            cbxLop.DataSource = lstLHP;
            cbxLop.DisplayMember = "TenLopHocPhan";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataDiem dataDiem = new dataDiem();
            //int maLopHocPhan = 0;
            //LopHocPhan lopHocPhan = (LopHocPhan)cbxLop.SelectedItem;
            //if(lopHocPhan != null)
            //{
            //    maLopHocPhan = lopHocPhan.MaLopHocPhan;
            //}
            //if (cbxTieuChi.Text == "Tất cả")
            //    bsLop.DataSource = dataDiem.tkLop("0", "10", maLopHocPhan);
            //if (cbxTieuChi.Text == "<4")
            //    bsLop.DataSource = dataDiem.tkLop("0", "4", maLopHocPhan);
            //if (cbxTieuChi.Text == "<4")
            //    bsLop.DataSource = dataDiem.tkLop("4", "5.5", maLopHocPhan);
            //if (cbxTieuChi.Text == "<4")
            //    bsLop.DataSource = dataDiem.tkLop("5.5", "7", maLopHocPhan);
            //if (cbxTieuChi.Text == "<4")
            //    bsLop.DataSource = dataDiem.tkLop("7", "8.5", maLopHocPhan);
            //if (cbxTieuChi.Text == "<4")
            //    bsLop.DataSource = dataDiem.tkLop("8.5", "10", maLopHocPhan);
            //gridLop.DataSource = bsLop;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataDiem dataDiem = new dataDiem();
            int maLopHocPhan = 0;
            LopHocPhan lopHocPhan = (LopHocPhan)cbxLop.SelectedItem;
            if (lopHocPhan != null)
            {
                maLopHocPhan = lopHocPhan.MaLopHocPhan;
            }
            if (cbxTieuChi.Text == "Tất cả")
                bsLop.DataSource = dataDiem.tkLop("0", "10", maLopHocPhan);
            else if (cbxTieuChi.Text == "<4")
                bsLop.DataSource = dataDiem.tkLop("0", "4", maLopHocPhan);
            else if (cbxTieuChi.Text == "4 đến 5,5")
                bsLop.DataSource = dataDiem.tkLop("4", "5.5", maLopHocPhan);
            else if (cbxTieuChi.Text == "5,5 đến 7")
                bsLop.DataSource = dataDiem.tkLop("5.5", "7", maLopHocPhan);
            else if (cbxTieuChi.Text == "7 đến 8,5")
                bsLop.DataSource = dataDiem.tkLop("7", "8.5", maLopHocPhan);
            else if (cbxTieuChi.Text == ">8,5")
                bsLop.DataSource = dataDiem.tkLop("8.5", "10", maLopHocPhan);
            gridLop.DataSource = bsLop;
        }
    }
}
