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
    public partial class QuanLyLopHocPhan : Form
    {
        public QuanLyLopHocPhan()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            QLLHPthem frmQLLHPthem = new QLLHPthem();
            frmQLLHPthem.ShowDialog();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            QLLHP_QLSV frmQLLHP_QLSV = new QLLHP_QLSV();
            frmQLLHP_QLSV.ShowDialog();
        }
    }
}
