
namespace _3S_project.GUI.FormAdmin.FormSinhVien
{
    partial class frmQuanLySinhVien
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
            this.components = new System.ComponentModel.Container();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bsQuanLySinhVien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLySinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 20);
            this.textBox4.TabIndex = 35;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.tenSinhVIen,
            this.sinhVien,
            this.gioiTinh,
            this.diaChi,
            this.tenLop1,
            this.Sua,
            this.Xoa});
            this.dataGridView4.Location = new System.Drawing.Point(-1, 190);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(864, 188);
            this.dataGridView4.TabIndex = 34;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            this.dataGridView4.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView4_CellFormatting);
            // 
            // maSinhVien
            // 
            this.maSinhVien.DataPropertyName = "MaSinhVien";
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.Name = "maSinhVien";
            // 
            // tenSinhVIen
            // 
            this.tenSinhVIen.DataPropertyName = "TenSinhVien";
            this.tenSinhVIen.HeaderText = "Tên sinh viên";
            this.tenSinhVIen.Name = "tenSinhVIen";
            // 
            // sinhVien
            // 
            this.sinhVien.DataPropertyName = "DateTime";
            this.sinhVien.HeaderText = "Ngày sinh";
            this.sinhVien.Name = "sinhVien";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // tenLop1
            // 
            this.tenLop1.DataPropertyName = "TenLop";
            this.tenLop1.HeaderText = "Tên lớp";
            this.tenLop1.Name = "tenLop1";
            this.tenLop1.Width = 150;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "Sua";
            this.Sua.HeaderText = "Sửa";
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            this.Sua.Width = 75;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xoá";
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xoá";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 75;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(80, 144);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(169, 30);
            this.button12.TabIndex = 33;
            this.button12.Text = "Thêm mới sinh viên";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(380, 100);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(93, 30);
            this.button13.TabIndex = 32;
            this.button13.Text = "Tìm kiếm";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 29;
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 380);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "frmQuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuanLySinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bsQuanLySinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVIen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop1;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}