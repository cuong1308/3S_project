using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI.FormMain
{
    public partial class FormMainQuanLy : Form
    {
        public FormMainQuanLy(Model.TaiKhoan tk)
        {
            InitializeComponent();
            label2.Text = "Xin chào " + tk.TenUser;
        }
    }
}
