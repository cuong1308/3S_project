
namespace _3S_project.GUI.FormAdmin.FormSinhVien
{
    partial class ThemSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Button();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(254, 226);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Location = new System.Drawing.Point(112, 104);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(53, 21);
            this.cbxGioiTinh.TabIndex = 28;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(112, 144);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(157, 20);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(112, 27);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(157, 20);
            this.txtTenSinhVien.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Sinh viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(112, 65);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(157, 20);
            this.dtpNgaySinh.TabIndex = 30;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(112, 182);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(157, 21);
            this.cbxLop.TabIndex = 31;
            // 
            // ThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 275);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ThemSinhVien";
            this.Text = "ThemSinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbxLop;
    }
}