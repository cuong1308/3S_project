﻿using _3S_project.GUI.FormAdmin.FormMonHoc;
using _3S_project.GUI.FormAdmin.FormQuanLyKhoa;
using _3S_project.GUI.FormAdmin.FormSinhVien;
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

namespace _3S_project.GUI.FormMain
{
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin(TaiKhoan tk)
        {
            InitializeComponent();
        }

        private void quảnLýTaiffKhoảnUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMonHoc frmMH = new frmQuanLyMonHoc();
            frmMH.ShowDialog();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien frmQLSV = new frmQuanLySinhVien();
            frmQLSV.ShowDialog();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKhoa formQuanLyKhoa = new FormQuanLyKhoa();
            formQuanLyKhoa.ShowDialog();
        }

        private void theoTrungBìnhMônToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void theoMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void theoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
