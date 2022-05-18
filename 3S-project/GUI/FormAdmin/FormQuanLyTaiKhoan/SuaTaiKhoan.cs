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

namespace _3S_project.GUI.FormAdmin.FormQuanLyTaiKhoan
{
    public partial class SuaTaiKhoan : Form
    {
        public SuaTaiKhoan(Model.TaiKhoan taiKhoan)
        {
            InitializeComponent();
            dataGiangVien dataGiangVien = new dataGiangVien();
            var lstGV = dataGiangVien.getlstGiangVien();
            lstGV.Insert(0, new Model.GiangVien() { TenGiangVien = "Không",MaGiangVien = 0 });
            cbxGiangVien.DataSource = lstGV;
            cbxGiangVien.DisplayMember = "TenGiangVien"; int count = 0;
            foreach (GiangVien gv in lstGV)
            {
                if (taiKhoan.GiangVien.MaGiangVien == gv.MaGiangVien)
                {
                    break;
                }

                else
                    count++;

            }
            cbxGiangVien.SelectedIndex = count;
            txtEmail.Text = taiKhoan.Email;
            txtPass.Text = taiKhoan.MatKhau;
            txtPassConf.Text = taiKhoan.MatKhau;
        }
    }
}
