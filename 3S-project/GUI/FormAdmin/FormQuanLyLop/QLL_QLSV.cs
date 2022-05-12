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
    public partial class QLL_QLSV : Form
    {
        public QLL_QLSV()
        {
            InitializeComponent();
        }

        private void themsv_Click(object sender, EventArgs e)
        {
            themsv frmthemsv = new themsv();
            frmthemsv.ShowDialog();

        }

        private void suasv_Click(object sender, EventArgs e)
        {
            suasv frmsuasv = new suasv();
            frmsuasv.ShowDialog();

        }

        private void xoasv_Click(object sender, EventArgs e)
        {
            Xoasv frmxoasv = new Xoasv();
            frmxoasv.ShowDialog();

        }
    }
}
