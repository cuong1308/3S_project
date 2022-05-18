using _3S_project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_project.GUI.FormAdmin.QuanLyGiangVien
{
    public partial class FormSuaGV : Form
    {
        public FormSuaGV()
        {
            InitializeComponent();
        }
        public FormSuaGV(Model.GiangVien giangVien)
        {
            InitializeComponent();
            labMaGiangVien.Text = giangVien.MaGiangVien.ToString();
            txtTenGiangVien.Text = giangVien.TenGiangVien;
        }
        private void FormSuaGV_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string temp = txtTenGiangVien.Text;
            isvalid_tenGV(temp);
            if(isvalid_tenGV(temp) == true)
            {
                dataGiangVien dataGV = new dataGiangVien();
                dataGV.Sua(int.Parse(labMaGiangVien.Text.Trim()), txtTenGiangVien.Text);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Tên không hợp lệ! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool isvalid_tenGV(string txt)
        {
            Regex check = new Regex(@"^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
                                                    "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
                                                        "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");//  @""  --- ^([^a-z0-9A-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+)$    @"^([A-Z][a-z-A-z]+)$"
            bool value = false;
            value = check.IsMatch(txt);
            if (value == true)
            {
                return value;
            }
            else
            {
                return value;
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
