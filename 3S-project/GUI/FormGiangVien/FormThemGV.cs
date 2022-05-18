using _3S_project.Data;
using _3S_project.Model;
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
    public partial class FormThemGV : Form
    {
        public FormThemGV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // bool ckh = false;
            string temp = txtGiangVien.Text;
            isvalid_tenGV(temp);
            if (isvalid_tenGV(temp) == true)
            {
                // 1. Thu thập dữ liệu trên GUI
                string tenGiangVien = txtGiangVien.Text;
                GiangVien gv = new GiangVien();
                gv.TenGiangVien = tenGiangVien;

                // 3. Thực hiện lưu lên csdl
                dataGiangVien dtGV = new dataGiangVien();
                dtGV.Them(gv.TenGiangVien);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên không hợp lệ!, Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            /* isvalid_tenGV(txtGiangVien.Text);
             bool chk = isvalid_tenGV(txtGiangVien.Text);
             if (chk == true)
             {

             }*/

        }
   
        public bool isvalid_tenGV(string txt)
        {
            Regex check = new Regex(@"^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
                                                    "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
                                                        "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");//  @""  --- ^([^a-z0-9A-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+)$    @"^([A-Z][a-z-A-z]+)$"
            bool value = false;
            value = check.IsMatch(txt);
            if(value == true)
            {
                return value;
            }
            else
            {  
                return value;
            }
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
