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
    public partial class Quanlylop : Form
    {
        public Quanlylop()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            QuanLyLopHocPhan frmQuanLyLopHocPhan = new QuanLyLopHocPhan();
            frmQuanLyLopHocPhan.ShowDialog();
        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Quanlylop frmQuanlylop = new Quanlylop();
            frmQuanlylop.ShowDialog();
        }
    }
}
