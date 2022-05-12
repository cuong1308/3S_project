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

namespace _3S_project.GUI.FormAdmin.FormQuanLyKhoa
{
    public partial class FormKhoaNew : Form
    {
        public Khoa InsertedKhoa { get; private set; }

        public FormKhoaNew()
        {
            InitializeComponent();
        }

        private void FormKhoaNew_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Thu thập dữ liệu trên GUI

            string tenKhoa = txtTenKhoa.Text;

            // 2. Thành lập đối tượng sach
            Khoa x = new Khoa();

            x.TenKhoa = tenKhoa;

            // 3. Thực hiện lưu lên csdl
            dataKhoa dtKhoa = new dataKhoa();
            dtKhoa.Them(x.TenKhoa);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
