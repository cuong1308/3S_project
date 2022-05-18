
namespace _3S_project.GUI.FormAdmin.FormQuanLyLop
{
    partial class QLLQLSV
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
            this.txtQLSVLop = new System.Windows.Forms.TextBox();
            this.gridSinhVien = new System.Windows.Forms.DataGridView();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bsQLSVLop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQLSVLop)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQLSVLop
            // 
            this.txtQLSVLop.Location = new System.Drawing.Point(76, 99);
            this.txtQLSVLop.Name = "txtQLSVLop";
            this.txtQLSVLop.Size = new System.Drawing.Size(294, 20);
            this.txtQLSVLop.TabIndex = 42;
            this.txtQLSVLop.TextChanged += new System.EventHandler(this.txtQLSVLop_TextChanged);
            // 
            // gridSinhVien
            // 
            this.gridSinhVien.AllowUserToAddRows = false;
            this.gridSinhVien.AllowUserToDeleteRows = false;
            this.gridSinhVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.tenSinhVIen,
            this.sinhVien,
            this.gioiTinh,
            this.diaChi,
            this.tenLop1,
            this.Sua,
            this.Xoa});
            this.gridSinhVien.Location = new System.Drawing.Point(-4, 183);
            this.gridSinhVien.Name = "gridSinhVien";
            this.gridSinhVien.RowHeadersWidth = 51;
            this.gridSinhVien.Size = new System.Drawing.Size(864, 188);
            this.gridSinhVien.TabIndex = 41;
            this.gridSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSinhVien_CellContentClick);
            // 
            // maSinhVien
            // 
            this.maSinhVien.DataPropertyName = "MaSinhVien";
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.MinimumWidth = 6;
            this.maSinhVien.Name = "maSinhVien";
            this.maSinhVien.Width = 125;
            // 
            // tenSinhVIen
            // 
            this.tenSinhVIen.DataPropertyName = "TenSinhVien";
            this.tenSinhVIen.HeaderText = "Tên sinh viên";
            this.tenSinhVIen.MinimumWidth = 6;
            this.tenSinhVIen.Name = "tenSinhVIen";
            this.tenSinhVIen.Width = 125;
            // 
            // sinhVien
            // 
            this.sinhVien.DataPropertyName = "DateTime";
            this.sinhVien.HeaderText = "Ngày sinh";
            this.sinhVien.MinimumWidth = 6;
            this.sinhVien.Name = "sinhVien";
            this.sinhVien.Width = 125;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 125;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 125;
            // 
            // tenLop1
            // 
            this.tenLop1.DataPropertyName = "TenLop";
            this.tenLop1.HeaderText = "Tên lớp";
            this.tenLop1.MinimumWidth = 6;
            this.tenLop1.Name = "tenLop1";
            this.tenLop1.Width = 150;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "Sua";
            this.Sua.HeaderText = "Sửa";
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            this.Sua.Width = 50;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xoá";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xoá";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 50;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(76, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 30);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm mới sinh viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(376, 93);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 30);
            this.btnTimKiem.TabIndex = 39;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(279, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 36;
            // 
            // QLLQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 372);
            this.Controls.Add(this.txtQLSVLop);
            this.Controls.Add(this.gridSinhVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLLQLSV";
            this.Text = "QLLQLSV";
            this.Load += new System.EventHandler(this.QLLQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQLSVLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQLSVLop;
        private System.Windows.Forms.DataGridView gridSinhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bsQLSVLop;
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