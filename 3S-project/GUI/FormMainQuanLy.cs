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

namespace _3S_project.GUI
{
    public partial class FormMainQuanLy : Form
    {
        public FormMainQuanLy(Model.TaiKhoan tk)
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void searchGiangVien_enter(object sender, EventArgs e)
        {
            dataGiangVien dataGV = new dataGiangVien();
            var lstGV = dataGV.getlstGiangVien();
            bsQuanLyGiangVien.DataSource = lstGV;
            gridGV.DataSource = bsQuanLyGiangVien;



        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {

        }
    }
}
