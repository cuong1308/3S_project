using _3S_project.Data;
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
    public partial class ThongKeTrungBinhMon : Form
    {
        public ThongKeTrungBinhMon()
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
        }

        private void cbxTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataDiem dataDiem = new dataDiem();
            //if (cbxTieuChi.Text == "Tất cả") 
            //    bsDiemTrungBinh.DataSource = dataDiem.tkTBM("0", "10");
            //if(cbxTieuChi.Text == "<4")
            //    bsDiemTrungBinh.DataSource = dataDiem.tkTBM("0", "4");
            //if (cbxTieuChi.Text == "4 đến 5,5")
            //    bsDiemTrungBinh.DataSource = dataDiem.tkTBM("4", "5.5");
            //if (cbxTieuChi.Text == "5,5 đến 7")
            //    bsDiemTrungBinh.DataSource = dataDiem.tkTBM("5.5", "7");
            //if (cbxTieuChi.Text == "7 đến 8,5")
            //    bsDiemTrungBinh.DataSource = dataDiem.tkTBM("7", "8.5");
            //if (cbxTieuChi.Text == ">8,5")
            //    bsDiemTrungBinh.DataSource = dataDiem.tkTBM("8.5", "10");
            //dataGridView1.DataSource = bsDiemTrungBinh;
        }

        private void ThongKeTrungBinhMon_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            bsDiemTrungBinh.DataSource = null;
            dataDiem dataDiem = new dataDiem();
            if (cbxTieuChi.Text == "Tất cả")
                bsDiemTrungBinh.DataSource = dataDiem.tkTBM("0", "10");
            else if (cbxTieuChi.Text == "<4")
                bsDiemTrungBinh.DataSource = dataDiem.tkTBM("0", "4");
            else if (cbxTieuChi.Text == "4 đến 5,5")
                bsDiemTrungBinh.DataSource = dataDiem.tkTBM("4", "5.5");
            else if (cbxTieuChi.Text == "5,5 đến 7")
                bsDiemTrungBinh.DataSource = dataDiem.tkTBM("5.5", "7");
            else if (cbxTieuChi.Text == "7 đến 8,5")
                bsDiemTrungBinh.DataSource = dataDiem.tkTBM("7", "8.5");
            else if (cbxTieuChi.Text == ">8,5")
                bsDiemTrungBinh.DataSource = dataDiem.tkTBM("8.5", "10");
            dataGridView1.DataSource = bsDiemTrungBinh;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
